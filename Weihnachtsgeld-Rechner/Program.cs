using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    class Program
    {
        public static int alter;
        public static double gehalt;
        public static double treue;
        public static string name;
        static int AbstandLeft;

        public static void Main(string[] args)
        {
            Console.Title = "Weihnachtsgeld - Rechner";
            Weihnachtsgeld_Menu();
        }

        public static void Weihnachtsgeld_Menu()
        {
            string[] lines = new string[] {
                "Geben sie Ihren Namen ein","",
                "Geben sie Ihr Gehalt ein","",
                "Geben sie Ihr Alter ein","",
                "Geben sie die Zeit in der Sie zu der Firma gehören an!",""
            };
            GUI.GUIBuilder("DEIN WEIHNACHTSGELD!", lines, false);
            AbstandLeft = 10;
            Console.SetCursorPosition(AbstandLeft, 4);
            name = Console.ReadLine();
            Console.SetCursorPosition(AbstandLeft, 8);
            gehalt = ParseDouble();
            Console.SetCursorPosition(AbstandLeft, 12);
            alter = ParseInt();
            Console.SetCursorPosition(AbstandLeft, 16);
            treue = ParseDouble();
            Person person = new Person(name, alter, gehalt, treue);

            Weihnachtsgeld_Rechner(person);
        }
        public static double ParseDouble()
        {
            double Value = 0;
            while (!(double.TryParse(Console.ReadLine(), out Value)))
            {
                int AbstandUp = Console.CursorTop - 1;
                Console.SetCursorPosition(0, AbstandUp);
                GUI.NormaleZeile("Eingabe Fehlerhaft!!, bitte erneut eingeben");
                Console.SetCursorPosition(AbstandLeft, AbstandUp);
            }
            GUI.LeereZeile();
            return Value;
        }
        public static int ParseInt()
        {
            int Value = 0;
            while (!(int.TryParse(Console.ReadLine(), out Value)))
            {
                int AbstandUp = Console.CursorTop - 1;
                Console.SetCursorPosition(0, AbstandUp);
                GUI.NormaleZeile("Eingabe Fehlerhaft!!, bitte eine Ganze Zahl eingeben.");
                Console.SetCursorPosition(AbstandLeft, AbstandUp);
            }
            GUI.LeereZeile();
            return Value;
        }

        private static void Weihnachtsgeld_Rechner(Person person)
        {
            double entgeld = new double();

            if (person.GetAge() >= 50 && person.GetTreue() >= 20.0)
            {
                entgeld = person.GetGehalt() * 1.45;
            }
            else if (person.GetTreue() >= 15.0 || person.GetAge() >= 55)
            {
                entgeld = person.GetGehalt() * 1.4;
            }
            else
            {
                entgeld = person.GetGehalt() * 1.3;
            }
            string stentgled = entgeld.ToString();

            string[] line = new string[] { person.GetName() + ", Ihr Entgeld beträgt: ", stentgled + " EURO" };
            GUI.GUIBuilder("IHR ENTGELD!", line, false);

            Console.ReadKey(true);
            Weihnachtsgeld_Menu();
        }
    }
}