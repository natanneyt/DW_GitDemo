// Waar staat de enumeratie in de code? net voor de Main-methode

// Wat bepaalt de maximumsnelheid? variabele maxSpeed. Deze variabele is constant, dus kan tijdens het verloop van het programma niet meer gewijzigd worden
// Wat bepaalt de lengte van de race? De variabele finishDistance
// Waar in de code wordt gecheckt of de finishlijn bereikt is? Er wordt berekend wat de afstand tussen de auto en de finish line is, waarbij afstand 0 betekent dat de finishlijn bereikt is
// Wat bepaalt wanneer de benzine op is? Er is een variabele die 31 seconden lang aftelt, dan is de benzine op
// De verstreken tijd wordt vergeleken met de maximale racetijd en zo wordt al dan niet de status aangepast
// Aanpassing roadOffsets/halfRoadWidths: de baan is volledig recht en bevat geen variatie in breedte (snelste tijd 29,05 seconden)
// Aanpassing roadOffsets: de baan is nog steeds recht, maar de breedte wordt aangepast
// Aanpassing halfRoadWidths: de baan is weer golvend, maar de breedte is statisch
// roadOffsets past aan waar de baan getekend wordt op de lijn, halfRoadWidths past aan hoe breed deze is
// De game loop bedraagt alles in de do-while loop

// Huidige afstand parcours: variabele distance, aangepast aan het begin van de game loop
    // Dit is een double aangezien dit nodig is voor bepaalde berekeningen waar je een kommagetal als resultaat krijgt
// Distance elke frame met 5 verhogen: De auto gaat heel snel, aangezien dit meerdere keren per seconde gebeurt. De snelheidsindicatie heeft zo geen betekenis.

// Inputafhandeling: input wordt gelezen aan het begin van de do-whileloop. Deze past variabele carPosition aan
// -roadOffsets[0]: zorgt ervoor dat de auto op de baan start
// Keyboard Buffer niet legen: de auto stopt snel met rijden
// Links/rechts bewegen: gebeurt ongeveer even snel, aangezien er gewacht wordt aan het einde.

// Het scherm wordt getekend in de do-while loop
// screenLine houdt bij over welke lijn in het scherm het gaat
// offsetsIndex/RoadWidthIndex worden met modulo berekend aangezien deze getallen in [O, 100[ moeten liggen (de lengte van 1 baangolf is 100 lijnen)
// We bewegen de baan i.p.v de auto zodat we de locatie van de auto snel terug kunnen vinden, voor o.a. de statussen en bottomLine
// Programma crasht indien de positie van de linkerkant van de baan negatief wordt, of de lengte van het gras rechts negatief is
// De twee graszijdes zijn anders getekend: kleuren van foreground en background zijn rechts omgewisseld
// spaces - spaces / 2 aangezien spaces / 2 al aan de linkerkant staat en de baan anders te lang wordt

namespace EBDSolution
{
    internal class Program
    {
        enum Status { Driving, Coasting, Stopped };

        static void Main(string[] args)
        {
            const string version = "2021.11.15.12.00";
            const int intendedFrameRate = 30; // gewenst aantal frame per seconde
            const double idealMillisPerFrame = 1000 / intendedFrameRate;

            const int screenWidth = 120; // breedte van het speelscherm
            const int screenHeight = 25; // hoogte van het speelscherm
            const int screenMiddle = screenWidth / 2; // de kolom in het midden van het scherm

            const int finishDistance = 1000; // totale lengte van de race

            const double poweredAcceleration = 5; // versnelling als er nog benzine is
            const double offRoadDecelerationFraction = 0.9; // vertragingsfactor indien off-road
            const double unpoweredDecelerationFraction = 1.2; // vertragingsfactor indien benzine op is

            const double maxSpeed = 40;
            const double maxRaceTimeInSeconds = 31; // na deze tijd is de benzine op

            // Maak console venster klaar
            Console.Title = "Eastbound and down " + version;
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.Clear();

            // Bouw een array dat de bochten in de weg bijhoudt,
            // dit zijn verschuivingen t.o.v. de middenlijn van een rechte weg.
            // Indien op index 36 een offset van -25 voorkomt, dan zal op afstand
            // 36 de weg 25 eenheden naar links verplaatst zijn
            const int numRoadOffsets = 100;
            const int roadOffsetVariance = 20;
            int[] roadOffsets = new int[numRoadOffsets];
            for (int i = 0; i < numRoadOffsets; i++)
            {
                roadOffsets[i] = Convert.ToInt32(Math.Round(roadOffsetVariance * Math.Cos(2 * Math.PI * i / numRoadOffsets)));
            }

            // Bouw een array dat (de helft van) de breedte van de weg bijhoudt.
            // Indien op index 36 een 13 voorkomt, dan is de weg op afstand 36
            // 2x13 eenheden breed.
            const int numRoadWidths = 125;
            const int basicRoadWidth = 20;
            const int roadWidthVariance = 4;
            int[] halfRoadWidths = new int[numRoadWidths];
            for (int i = 0; i < numRoadWidths; i++)
            {
                halfRoadWidths[i] = basicRoadWidth / 2 + Convert.ToInt32(Math.Round(roadWidthVariance / 2 * Math.Cos(2 * Math.PI * i / numRoadWidths)));
            }

            // Zet instructies op het scherm
            Console.WriteLine("Besturing gebeurt met de pijltjes toetsen links/rechts");
            Console.WriteLine("Kun je de finish halen vooraleer de benzine op is?");
            Console.WriteLine();
            Console.Write("Druk op een toets om te beginnen");
            Console.ReadKey(true);

            double raceTimeInSeconds; // houdt bij hoe lang de race al bezig is
            bool isSmokey = false; // voor de hele rappe ;)
            bool quit = false; // houdt bij of de gebruiker aangaf te willen stoppen
            while (!quit)
            {
                // IN ELKE ITERATIE VAN DEZE LOOP WORDT 1 RACE GEREDEN

                // Reset consolevenster (voor het geval gebruiker venstergrootte wijzigde tussen races)
                Console.SetWindowSize(screenWidth, screenHeight + 1);// extra ongebruikte regel om scrollen te vermijden
                Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
                Console.ResetColor();
                Console.Clear();

                // Reset allerlei race data
                // .. afstand
                double distance = 0; // de reeds afgelegde afstand in deze race
                int distanceLeft; // hoeveel afstand is er nog te gaan tot aan de finish
                                  // .. auto
                int carPosition = -roadOffsets[0]; // de horizontale positie van de auto t.o.v. het midden van een denkbeeldige rechte weg
                Status carStatus = Status.Driving; // houdt bij wat de auto aan het doen is (rijden/uitbollen/gestopt)
                double speed = 0; // de snelheid van de auto
                                  // .. timing en frames
                long ticksAtStartOfRace = DateTime.Now.Ticks; // tijdsmeting bij het begin van deze race
                long ticksAtStartOfPreviousFrame = ticksAtStartOfRace; // tijdsmeting bij het begin van het vorige frame
                int frameCount = 0; // hoeveel frame werden er in deze race getekend

                do
                {
                    // ELKE ITERATIE VAN DEZE LOOP IS EEN FRAME
                    // Dit is de gameloop die meermaals per seconde wordt doorlopen
                    // met (o.a.) de volgende taken :
                    // - afhandeling input
                    // - updaten van snelheid en afgelegde afstand
                    // - hertekenen van het scherm
                    // - tijdsmeting en checks

                    // bereken tijdsverschil in ticks sinds vorige iteratie
                    long ticksAtStartOfThisFrame = DateTime.Now.Ticks;
                    long ticksDifference = ticksAtStartOfThisFrame - ticksAtStartOfPreviousFrame;
                    ticksAtStartOfPreviousFrame = ticksAtStartOfThisFrame;

                    // Bereken afgelegde afstand op basis van snelheid en verstreken tijd sinds vorige iteratie
                    distance += (speed * ticksDifference / TimeSpan.TicksPerSecond);

                    // Bereken de totale race tijd
                    raceTimeInSeconds = Convert.ToDouble(ticksAtStartOfThisFrame - ticksAtStartOfRace) / TimeSpan.TicksPerSecond;

                    // Check of benzine op is
                    if (raceTimeInSeconds > maxRaceTimeInSeconds)
                    {
                        carStatus = Status.Coasting;
                    }

                    // Indien er een pijltjestoets werd ingedrukt, verplaats de wagen
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.LeftArrow)
                        {
                            carPosition++;
                        }
                        else if (cki.Key == ConsoleKey.RightArrow)
                        {
                            carPosition--;
                        }
                    }

                    // maak keyboard buffer leeg
                    // (er kunnen nog meer toetsdrukken inzitten en we willen niet dat die 'achterkomen')
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    // Teken het ganse scherm
                    Console.SetCursorPosition(0, 0);
                    string bottomLine = ""; // onderste regel van het scherm moet onthouden worden
                    for (int screenLine = 0; screenLine < screenHeight; screenLine++)
                    {
                        // DEZE LOOP HERTEKENT HET SCHERM, VAN BOVEN NAAR ONDER
                        // ELKE ITERATIE TEKENT 1 VOLLEDIGE HORIZONTALE LIJN

                        // Wat is de afstand (afgelegde weg) van deze lijn op het scherm
                        int lineDistance = Convert.ToInt32(distance) + (screenHeight - screenLine);

                        // Wat is de verschuiving van de weg op deze lijn?
                        int offsetIndex = lineDistance % roadOffsets.Length;
                        int lineOffset = roadOffsets[offsetIndex];

                        // Wat is de breedte van de weg op deze lijn?
                        int roadWidthIndex = lineDistance % halfRoadWidths.Length;
                        int lineHalfRoadWidth = halfRoadWidths[roadWidthIndex];

                        // Bereken de posities van de zijkanten van de weg
                        int roadLeftPosition = carPosition + screenMiddle + lineOffset - lineHalfRoadWidth;
                        int roadRightPosition = roadLeftPosition + 2 * lineHalfRoadWidth;

                        // Teken de linkerkant naast de weg (gras)
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                        string leftSide = new string('#', roadLeftPosition); // programma crasht indien roadLeftPosition negatief is
                        Console.Write(leftSide);

                        // Bepaal of er een tekst op de weg moet komen
                        string roadMessage = "";
                        int lineDistanceToFinish = finishDistance - lineDistance;
                        if (lineDistanceToFinish == 0)
                        {
                            roadMessage = "FINISH";
                        }
                        else if (lineDistance < 100 && lineDistance % 25 == 0)
                        {
                            roadMessage = "GO GO GO";
                        }
                        else if (carStatus == Status.Driving && lineDistance == finishDistance - 49)
                        {
                            roadMessage = "so";
                        }
                        else if (carStatus == Status.Driving && lineDistance == finishDistance - 50)
                        {
                            roadMessage = "close";
                        }
                        else if (lineDistanceToFinish % 200 == 0)
                        {
                            roadMessage = lineDistanceToFinish.ToString();
                        }

                        // Teken de weg
                        Console.ForegroundColor = ConsoleColor.White;
                        string road;
                        if (roadMessage.Length == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            road = new string(' ', lineHalfRoadWidth * 2);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            int spaces = lineHalfRoadWidth * 2 - roadMessage.Length;
                            if (spaces > 0)
                            {
                                road = new string(' ', spaces / 2) + roadMessage + new string(' ', spaces - spaces / 2);
                            }
                            else
                            {
                                road = roadMessage.Substring(0, lineHalfRoadWidth * 2);
                            }
                        }
                        Console.Write(road);

                        // Teken de rechterkant naast de weg (gras)
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        int rightSideWidth = screenWidth - roadRightPosition;
                        string rightSide = new string('#', rightSideWidth); // programma crasht indien rightSideWidth negatief is
                        Console.Write(rightSide);

                        // onthou onderste lijn van het scherm zodat we na de loop nog kunnen checken
                        // wat er onder de auto zit (i.e. de weg of gras)
                        if (screenLine == screenHeight - 1)
                        {
                            bottomLine = leftSide + road + rightSide;
                        }
                    }

                    // Check of de auto al dan niet op de weg staat (auto staat altijd op screenMiddle)
                    int indexUnderCar = bottomLine.Length / 2;
                    char symbolUnderCar = bottomLine[indexUnderCar];
                    bool isOffRoad = !(Char.IsLetterOrDigit(symbolUnderCar) || symbolUnderCar == ' ');

                    // Bereken snelheidsverandering op basis van
                    // - de ondergrond : op de weg of op het gras (off-road)
                    // - of er nog benzine is of niet
                    // rekening houdend met de verstreken tijd sinds de vorige iteratie (i.e. sinds vorige frame)
                    if (isOffRoad)
                    {
                        speed -= (speed * offRoadDecelerationFraction) * ticksDifference / TimeSpan.TicksPerSecond;
                    }
                    if (carStatus == Status.Driving)
                    {
                        speed += poweredAcceleration * ticksDifference / TimeSpan.TicksPerSecond;
                        // Zorg dat snelheid onder maxSpeed blijft
                        speed = Math.Min(maxSpeed, speed);
                    }
                    else if (carStatus == Status.Coasting)
                    {
                        speed -= (speed * unpoweredDecelerationFraction) * ticksDifference / TimeSpan.TicksPerSecond;
                        if (speed < 1)
                        {
                            carStatus = Status.Stopped;
                        }
                    }

                    // Teken de auto
                    Console.SetCursorPosition(screenMiddle, screenHeight - 1);
                    if (isOffRoad)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (carStatus == Status.Driving)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    Console.Write("^");

                    // Toon afstand en snelheid
                    Console.SetCursorPosition(0, screenHeight - 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    distanceLeft = finishDistance - Convert.ToInt32(distance);
                    Console.Write($"{distanceLeft,4:d} {speed,2:f0}");

                    // Wacht eventjes zodat volgende iteratie niet te snel komt. Dit beperkt de frame rate,
                    // maar zorgt er ook voor dat de bewegingssnelheid links/rechts bij iedereen
                    // ongeveer gelijk is (want de links/rechts verplaatsing gebeurt 1x per iteratie
                    // dus hoe meer iteraties per seconde, hoe sneller je links/rechts zou kunnen
                    // bewegen).
                    long ticksAtEndOfThisFrame = DateTime.Now.Ticks; // tijdsmeting op het einde van dit frame
                    double millisThisFrame = Convert.ToDouble(ticksAtEndOfThisFrame - ticksAtStartOfThisFrame) / TimeSpan.TicksPerMillisecond;
                    int millisToWait = Convert.ToInt32(Math.Round(idealMillisPerFrame - millisThisFrame));
                    System.Threading.Thread.Sleep(Math.Max(0, millisToWait));

                    // tel deze frame
                    frameCount++;

                    // De race eindigt pas als de finish bereikt wordt of de auto stilvalt
                } while (distanceLeft > 0 && carStatus != Status.Stopped);

                // Bereken de gemiddelde framerate (zou +- gelijk moeten zijn aan 'intendedFrameRate')
                long ticksAtEndOfRace = DateTime.Now.Ticks;
                double averageMillisPerFrame = Convert.ToDouble(ticksAtEndOfRace - ticksAtStartOfRace) / TimeSpan.TicksPerMillisecond / frameCount;
                double averageFrameRate = 1000 / averageMillisPerFrame;

                // Toon de gemiddelde framerate
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 0);
                Console.Write($"{averageFrameRate,0:f1} fps");

                // Maak resultaat bericht
                string resultMessage = " [SPACE = start, ESC = stop]";
                if (distanceLeft <= 0)
                {
                    resultMessage = $"Finish bereikt na {raceTimeInSeconds,0:f2} seconden" + resultMessage;
                    if (maxRaceTimeInSeconds - raceTimeInSeconds > 1)
                    {
                        // voor de hele rappe
                        isSmokey = true;
                        resultMessage += " [ENTER voor beloning]";
                    }
                }
                else
                {
                    resultMessage = $"Stilgevallen op {distanceLeft} van het einde" + resultMessage;
                }

                // Toon resultaat bericht
                int spacesNeeded = Console.WindowWidth - resultMessage.Length;
                int spacesLeftSide = spacesNeeded / 2;
                int spacesRightSide = spacesNeeded - spacesLeftSide;
                Console.SetCursorPosition(0, screenHeight - 1);
                Console.Write(new string(' ', spacesLeftSide));
                Console.Write(resultMessage);
                Console.Write(new string(' ', spacesRightSide));

                // Wacht tot de gebruiker een gepaste toets indrukt
                bool wait = true;
                while (wait)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Spacebar)
                    {
                        wait = false;
                    }
                    else if (cki.Key == ConsoleKey.Escape)
                    {
                        wait = false;
                        quit = true;
                    }
                    else if (cki.Key == ConsoleKey.Enter && isSmokey)
                    {
                        // voor de hele rappe
                        var uri = "https://www.youtube.com/watch?v=jAG4XXCOj48&start=11";
                        var psi = new System.Diagnostics.ProcessStartInfo();
                        psi.UseShellExecute = true;
                        psi.FileName = uri;
                        System.Diagnostics.Process.Start(psi);
                    }
                }

                // EINDE VAN ITERATIE VOOR DEZE RACE
            }
        }
    }
}
