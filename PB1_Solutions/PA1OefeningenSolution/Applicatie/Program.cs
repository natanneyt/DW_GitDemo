using System;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Applicatie
{
    // DPA1.menu
    // 1. Waarom eindigt het programma pas als de gebruiker keuze 5 kiest?
        // -> De overkoepelende loop eindigt als de gebruiker voor 5 kiest.
    // 2. Wat bepaalt dat keuze 4 in het menu de 'alle details van een persoon zien' functionaliteit in gang steekt?
        // -> Op het begin werd het getal 4 gelinkt aan de variable KeuzeToon, waarmee het programma de keuze vergelijkt om een if-lus uit te voeren.

    // DPA1.details
    // 1. Het programma gaat pas verder als je een geldige persoon gekozen hebt, waar gebeurt dit?
        // -> De gegeven index wordt vergeleken met het aantal personen in de tabel, en de vraag wordt herhaald indien de index niet past. Dit gebeurt in de if-lus van KeuzeToon.
    // 2. Hoe is de informatie van één persoon over de verschillende arrays verdeeld?
        // -> De informatie is gelinkt door eenzelfde index.
    // 3. Waarvoor dient de variabele aantalPersonen in verband met de arrays?
        // -> Deze wordt gebruikt om te bereken wat de maximale index is, en zo te zien of een index correct is.
    // 4. Hoe komt de initiële data in het programma terecht (i.e. de info over Jan en Mieke)?
        // -> Deze worden bij de start aangemaakt en in de huidige aantalPersonen-index gestopt, die daarna met 1 verhoogd wordt.
    // 5. Hoe wordt de true/false waarde voor isVrouw omgezet naar vrouw/man in de output?
        // -> [conditionele expressie] ? [waarde indien true] : [waarde indien false]

    // DPA1.toevoegen
    // 1. Hoe zorgt het programma ervoor dat lege tekst niet aanvaard wordt als voornaam?
        // -> De loop blijft de vraag opnieuw stellen zolang het antwoord een lege string is.
    // 2. Waarom hoeft er bij het geslacht niet op een lege string gecontroleerd te worden?
        // -> Er wordt gecontroleerd op of het antwoord "m" of "v" is, en een andere input wordt niet aanvaard.
    // 3. Hoe wordt de m/v input bij geslacht, omgezet naar een false/true waarde voor isVrouw?
        // -> De boolean waarde is gelijk aan de conditionele expressie antwoord=="v": true indien "v", false indien "m".
    // 4. Hoe wordt de ingevoerde data onthouden zolang het programma nog geen antwoord heeft op de Wil u deze gegevens bewaren(j/n)? vraag?
        // -> De gegevens worden onthouden in de lijst, maar aantalPersonen wordt enkel verhoogd indien gegevens bewaard moeten worden.
    // 5. Waarom moet deze onthouden data niet expliciet verwijderd worden als de gebruiker deze vraag met n beantwoordt?
        // -> Indien gegevens niet moeten worden onthouden, zullen de gegevens overschreven worden door de volgende waardes.

    // DPA1.aanpassen
    // 1. Waarom is lege input bij voornaam dit keer WEL aanvaardbaar (i.t.t.bij het toevoegen)?
        // -> Indien een lege string werd ingegeven, wordt deze input genegeerd en blijft de oude waarde onaangepast in de array staan.
    // 2. Hoe wordt er omgegaan met lege input voor het aantal kinderen en waarom is -1 ok in dit geval?
        // -> Indien deze waarde -1 is, wordt deze ook genegeerd en wordt de originele waarde niet aangepast.
    // 3. Wat zou je doen als ALLE mogelijke int waarden geldig zouden zijn om 'lege input' aan te duiden?
        // -> Voor de string-waardes zou je kijken of deze te parseren zijn, en in de catch-methode de code schrijven om niet-lege input te verwerken.
    // 4. Hoe weet het programma of de voornaam moet overschreven worden?
        // -> Het programma controleert of de variabele voornaam een lege string is en indien voornaam niet leeg is wordt er om bevestiging gevraagd aan de gebruiker.
    // 5. Hoe weet het programma of het aantal kinderen moet overschreven worden?
        // -> Indien de variabele aantalKinderen -1 bedraagt wordt die waarde genegeerd. Lege strings worden ook genegeerd. 
        //    In de andere gevallen moet de waarde overschreven worden.

    // DPA1.verwijderen
    // 1. Hoe gaat het verwijderen in z’n werk?
        // -> Alle waarden die op een volgende index komen worden 1 index naar voren geschoven, en de variabele aantalPersonen wordt met 1 verminderd.
    // 2. Wat doen al die array manipulaties in de loop eigenlijk?
        // -> Ze zorgen ervoor dat de indexen overeen komen met het getal van aantalPersonen.
    // 3. Waarom moeten er in de arrays geen waarden op 0/false/null gezet worden bij het verwijderen?
        // De waarden die niet overeen komen met een getal tussen 0 en (aantalPersonen - 1) worden genegeerd, dus het maakt niet uit welke waarden op die indices staan.

    // DPA1.varia
    // 1. Hoe kun je (als gebruiker) het programma in zo’n toestand krijgen dat de gebruiker onmogelijk nog input kan geven die door het programma aanvaard wordt?
        // -> (De gebruiker kan 20 mensen toegevoegd hebben waardoor geen 21ste meer aanvaard wordt.) De persoon kan voor 5 kiezen.
    // 2. Hoe kun je het programma laten crashen met een IndexOutOfRangeException?
        // -> Er kunnen maar 20 mensen toegevoegd worden. Een 21ste persoon zou dus een exception geven.
    // 3. Wat vind je van de scope van de variabele isCorrectAntwoord, is die te ruim of net goed?
        // -> Variabele niet gevonden (te klein dus?). Indien de scope vergroot moet worden zou ik deze variabele aanmaken.
    // 4. Is de variabele aantalPersonen vermijdbaar?
        // -> Ja, maar dan zou je een List moeten gebruiken waarin je variabelen kan verwijderen.
    // 5. Kan het verwijderen van een persoon gerealiseerd worden zonder al die array verschuivingen?
        // -> Ja, met een List i.p.v een Array.

    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxPersonen = 20;

            const int KeuzeVoegToe = 1;
            const int KeuzeVerwijder = 2;
            const int KeuzeBewerk = 3;
            const int KeuzeToon = 4;
            const int KeuzeStop = 5;

            string[] voornamen = new string[MaxPersonen];
            string[] familienamen = new string[MaxPersonen];
            bool[] isVrouwen = new bool[MaxPersonen];
            string[] postcodes = new string[MaxPersonen];
            string[] gemeenten = new string[MaxPersonen];
            int[] aantalKinderen = new int[MaxPersonen];
            int aantalPersonen = 0;

            voornamen[aantalPersonen] = "Jan";
            familienamen[aantalPersonen] = "Janssens";
            isVrouwen[aantalPersonen] = false;
            postcodes[aantalPersonen] = "8501";
            gemeenten[aantalPersonen] = "Heule";
            aantalKinderen[aantalPersonen] = 2;
            aantalPersonen++;

            voornamen[aantalPersonen] = "Mieke";
            familienamen[aantalPersonen] = "Mickelsen";
            isVrouwen[aantalPersonen] = true;
            postcodes[aantalPersonen] = "9000";
            gemeenten[aantalPersonen] = "Gent";
            aantalKinderen[aantalPersonen] = 0;
            aantalPersonen++;

            int keuze = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Gekende personen");
                Console.WriteLine("----------------");
                for (int i = 0; i < aantalPersonen; i++)
                {
                    Console.WriteLine($"{i,2} {voornamen[i]} {familienamen[i]}, {gemeenten[i]}");
                }

                Console.WriteLine();
                Console.WriteLine("Hoofdmenu");
                Console.WriteLine("---------");
                Console.WriteLine("1) een persoon toevoegen");
                Console.WriteLine("2) een persoon verwijderen");
                Console.WriteLine("3) een persoon aanpassen");
                Console.WriteLine("4) alle details van een persoon zien");
                Console.WriteLine("5) stoppen");
                Console.WriteLine();

                do
                {
                    Console.Write("Wat wil u doen : ");
                    string keuzeAlsTekst = Console.ReadLine().Trim();

                    try
                    {
                        keuze = int.Parse(keuzeAlsTekst);

                        if (keuze < KeuzeVoegToe || keuze > KeuzeStop)
                        {
                            Console.WriteLine("Keuze buiten bereik. Probeer opnieuw.");
                            continue;
                        }

                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                    }

                } while (true);
                Console.WriteLine();

                if (keuze == KeuzeVoegToe)
                {
                    Console.WriteLine("Persoon toevoegen");
                    Console.WriteLine("-----------------");

                    string antwoord;

                    do
                    {
                        Console.Write("Voornaam : ");
                        antwoord = Console.ReadLine().Trim();
                    } while (antwoord == "");
                    voornamen[aantalPersonen] = antwoord;

                    do
                    {
                        Console.Write("Familienaam : ");
                        antwoord = Console.ReadLine().Trim();
                    } while (antwoord == "");
                    familienamen[aantalPersonen] = antwoord;

                    do
                    {
                        Console.Write("Geslacht (m/v) : ");
                        antwoord = Console.ReadLine().Trim().ToLower();
                    } while (antwoord != "m" && antwoord != "v");
                    isVrouwen[aantalPersonen] = (antwoord == "v");

                    do
                    {
                        Console.Write("Postcode : ");
                        antwoord = Console.ReadLine().Trim();
                    } while (antwoord == "");
                    postcodes[aantalPersonen] = antwoord;

                    do
                    {
                        Console.Write("Gemeente : ");
                        antwoord = Console.ReadLine().Trim();
                    } while (antwoord == "");
                    gemeenten[aantalPersonen] = antwoord;

                    int aantal;
                    do
                    {
                        Console.Write("Aantal kinderen : ");
                        string aantalKinderenAlsTekst = Console.ReadLine().Trim();

                        try
                        {
                            aantal = int.Parse(aantalKinderenAlsTekst);

                            if (aantal < 0)
                            {
                                Console.WriteLine("Het aantal kinderen kan niet negatief zijn. Probeer opnieuw.");
                                continue;
                            }

                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Ongeldige waarde. Probeer opnieuw.");
                        }
                    } while (true);
                    aantalKinderen[aantalPersonen] = aantal;

                    Console.WriteLine();
                    Console.WriteLine("Ingevoerde gegevens");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("voornaam    : " + voornamen[aantalPersonen]);
                    Console.WriteLine("familienaam : " + familienamen[aantalPersonen]);
                    Console.WriteLine("geslacht    : " + (isVrouwen[aantalPersonen] ? "vrouw" : "man"));
                    Console.WriteLine("postcode    : " + postcodes[aantalPersonen]);
                    Console.WriteLine("gemeente    : " + gemeenten[aantalPersonen]);
                    Console.WriteLine("kinderen    : " + aantalKinderen[aantalPersonen]);
                    do
                    {
                        Console.Write("Wil u deze gegevens bewaren (j/n) : ");
                        antwoord = Console.ReadLine().Trim().ToLower();
                    } while (antwoord != "j" && antwoord != "n");
                    if (antwoord == "j")
                    {
                        aantalPersonen++;
                    }

                }
                else if (keuze == KeuzeVerwijder)
                {
                    Console.WriteLine("Persoon verwijderen");
                    Console.WriteLine("-------------------");

                    int index;
                    do
                    {
                        Console.Write("Welke persoon wil u verwijderen : ");
                        string indexAlsTekst = Console.ReadLine().Trim();

                        try
                        {
                            index = int.Parse(indexAlsTekst);

                            if (index < 0 || index >= aantalPersonen)
                            {
                                Console.WriteLine("Keuze buiten bereik. Probeer opnieuw.");
                                continue;
                            }

                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        }
                    } while (true);

                    // toon detail van persoon op positie 'index'
                    Console.WriteLine("voornaam    : " + voornamen[index]);
                    Console.WriteLine("familienaam : " + familienamen[index]);
                    Console.WriteLine("geslacht    : " + (isVrouwen[index] ? "vrouw" : "man"));
                    Console.WriteLine("postcode    : " + postcodes[index]);
                    Console.WriteLine("gemeente    : " + gemeenten[index]);
                    Console.WriteLine("kinderen    : " + aantalKinderen[index]);

                    string antwoord;
                    do
                    {
                        Console.Write("Wil u de gegevens van deze persoon daadwerkelijk verwijderen (j/n) : ");
                        antwoord = Console.ReadLine().Trim().ToLower();
                    } while (antwoord != "j" && antwoord != "n");
                    if (antwoord == "j")
                    {
                        // verwijder de persoon op positie 'index'
                        for (int i = index; i < aantalPersonen - 1; i++)
                        {
                            voornamen[i] = voornamen[i + 1];
                            familienamen[i] = familienamen[i + 1];
                            isVrouwen[i] = isVrouwen[i + 1];
                            postcodes[i] = postcodes[i + 1];
                            gemeenten[i] = gemeenten[i + 1];
                            aantalKinderen[i] = aantalKinderen[i + 1];
                        }
                        aantalPersonen--;
                    }
                }
                else if (keuze == KeuzeBewerk)
                {
                    Console.WriteLine("Persoon bewerken");
                    Console.WriteLine("----------------");

                    int index;
                    do
                    {
                        Console.Write("Welke persoon wil u bewerken : ");
                        string indexAlsTekst = Console.ReadLine().Trim();

                        try
                        {
                            index = int.Parse(indexAlsTekst);

                            if (index < 0 || index >= aantalPersonen)
                            {
                                Console.WriteLine("Keuze buiten bereik. Probeer opnieuw.");
                                continue;
                            }

                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        }
                    } while (true);

                    Console.WriteLine("Indien u een gegeven ongewijzigd wil laten, druk dan gewoon op enter.");

                    Console.Write("Voornaam : ");
                    string voornaam = Console.ReadLine().Trim();

                    Console.Write("Familienaam : ");
                    string familienaam = Console.ReadLine().Trim();

                    string geslacht;
                    do
                    {
                        Console.Write("Geslacht (m/v) : ");
                        geslacht = Console.ReadLine().Trim().ToLower();
                    } while (geslacht != "" && geslacht != "m" && geslacht != "v");

                    Console.Write("Postcode : ");
                    string postcode = Console.ReadLine().Trim();

                    Console.Write("Gemeente : ");
                    string gemeente = Console.ReadLine().Trim();

                    int aantal = -1;
                    do
                    {
                        Console.Write("Aantal kinderen : ");
                        string aantalKinderenAlsTekst = Console.ReadLine().Trim();

                        if (aantalKinderenAlsTekst == "")
                        {
                            break;
                        }
                        else
                        {
                            try
                            {
                                aantal = int.Parse(aantalKinderenAlsTekst);

                                if (aantal < 0)
                                {
                                    Console.WriteLine("Het aantal kinderen kan niet negatief zijn. Probeer opnieuw.");
                                    continue;
                                }

                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Ongeldige waarde. Probeer opnieuw.");
                            }
                        }

                    } while (true);

                    Console.WriteLine();
                    Console.WriteLine("Gewijzigde gegevens");
                    Console.WriteLine("-------------------");
                    if (voornaam != "")
                    {
                        Console.WriteLine("voornaam    : " + voornaam);
                    }
                    if (familienaam != "")
                    {
                        Console.WriteLine("familienaam : " + familienaam);
                    }
                    if (geslacht != "")
                    {
                        Console.WriteLine("geslacht    : " + (geslacht == "v" ? "vrouw" : "man"));
                    }
                    if (postcode != "")
                    {
                        Console.WriteLine("postcode    : " + postcode);
                    }
                    if (gemeente != "")
                    {
                        Console.WriteLine("gemeente    : " + gemeente);
                    }
                    if (aantal != -1)
                    {
                        Console.WriteLine("kinderen    : " + aantal);
                    }

                    string antwoord;
                    do
                    {
                        Console.Write("Wil u deze wijziging(en) bewaren (j/n) : ");
                        antwoord = Console.ReadLine().Trim().ToLower();
                    } while (antwoord != "j" && antwoord != "n");
                    if (antwoord == "j")
                    {
                        if (voornaam != "")
                        {
                            voornamen[index] = voornaam;
                        }
                        if (familienaam != "")
                        {
                            familienamen[index] = familienaam;
                        }
                        if (geslacht != "")
                        {
                            isVrouwen[index] = (geslacht == "v");
                        }
                        if (postcode != "")
                        {
                            postcodes[index] = postcode;
                        }
                        if (gemeente != "")
                        {
                            gemeenten[index] = gemeente;
                        }
                        if (aantal != -1)
                        {
                            aantalKinderen[index] = aantal;
                        }
                    }
                }
                else if (keuze == KeuzeToon)
                {
                    int index;
                    do
                    {
                        Console.Write("Van welke persoon wil u de details zien : ");
                        string indexAlsTekst = Console.ReadLine().Trim();

                        try
                        {
                            index = int.Parse(indexAlsTekst);

                            if (index < 0 || index >= aantalPersonen)
                            {
                                Console.WriteLine("Keuze buiten bereik. Probeer opnieuw.");
                                continue;
                            }

                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        }
                    } while (true);

                    // toon detail van persoon op positie 'index'
                    Console.WriteLine("voornaam    : " + voornamen[index]);
                    Console.WriteLine("familienaam : " + familienamen[index]);
                    Console.WriteLine("geslacht    : " + (isVrouwen[index] ? "vrouw" : "man"));
                    Console.WriteLine("postcode    : " + postcodes[index]);
                    Console.WriteLine("gemeente    : " + gemeenten[index]);
                    Console.WriteLine("kinderen    : " + aantalKinderen[index]);
                    Console.WriteLine();
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                    Console.ReadLine();
                }

            } while (keuze != KeuzeStop);
        }
    }
}
