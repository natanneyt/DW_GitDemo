using D19printmetopmaak.Domein;

namespace D19printmetopmaak
{
    public class Program
    {

        static void PrintStyled(string text, IStyle style)
        {
            string styledText = style.GetStyledTextFor(text);
            Console.WriteLine(styledText);
        }

        static void Main(string[] args)
        {
            AllCapsStyle acs = new AllCapsStyle();
            ExclamationStyle es = new ExclamationStyle();
            CapitalCasingStyle ccs = new CapitalCasingStyle();

            PrintStyled("Veel geluk!", acs); // toont : VEEL GELUK!
            PrintStyled("Vergeet het niet...", es); // toont: Vergeet het niet!!!
            PrintStyled("geachte heer,", ccs); // toont : Geachte Heer,
        }
    }
}
