using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    class Program
    {
        public static int Personage;
        public static double Persongehalt;
        public static double Persontreue;
        public static string Personname;
        static int AbstandLeft;

        public static void Main(string[] args)
        {
            Console.Title = "Weihnachtsgeld - Rechner";
            Personname = "TEST";

            Weihnachtsgeld_Menu();
        }
        
        public static void Weihnachtsgeld_Menu()
        {
            string[] lines = new string[] {
                "Geben sie Ihr Gehalt ein","","Geben sie Ihr Alter ein","","Geben sie die Zeit in der Sie zu der Firma gehören an!","",""
            };
            GUIBuilder("DEIN WEIHNACHTSGELD!", lines, true);
            AbstandLeft = Console.CursorLeft;
            Console.SetCursorPosition(AbstandLeft, 3);
            Persongehalt = ParseDouble();
            Console.SetCursorPosition(AbstandLeft, 7);
            Personage = ParseInt();
            Console.SetCursorPosition(AbstandLeft, 11);
            Persontreue = ParseDouble();
            Person person = new Person(Personname, Personage, Persongehalt, Persontreue);

            Weihnachtsgeld_Rechner(person);
        }
        public static double ParseDouble()
        {
            double Value = 0;
            while (!(double.TryParse(Console.ReadLine(), out Value)))
            {
                int AbstandUp = Console.CursorTop - 1;
                Console.WriteLine("* Eingabe Fehlerhaft!!, bitte erneut eingeben");
                Console.SetCursorPosition(AbstandLeft, AbstandUp);
                Console.WriteLine("                                                ");
                Console.SetCursorPosition(AbstandLeft, AbstandUp);
            }
            Console.WriteLine("                                                ");
            return Value;
        }
        public static int ParseInt()
        {
            int Value = 0;
            while (!(int.TryParse(Console.ReadLine(), out Value)))
            {
                int AbstandUp = Console.CursorTop - 1;
                Console.WriteLine("* Eingabe Fehlerhaft!!, bitte eine Ganze Zahl eingeben.");
                Console.SetCursorPosition(AbstandLeft, AbstandUp);
                Console.WriteLine("                                                ");
                Console.SetCursorPosition(AbstandLeft, AbstandUp);
            }
            Console.WriteLine("                                                ");
            return Value;
        }

        private static void Weihnachtsgeld_Rechner(Person person)
        {
            double entgeld = new double();

            if (person.GetAge() >= 50 && person.GetTreue() >= 20.0)
            {
                entgeld = person.GetGehalt() * 1.45;
            }
            else if(person.GetTreue() >= 15.0 || person.GetAge() >= 55)
            {
                entgeld = person.GetGehalt() * 1.4;
            }
            else
            {
                entgeld = person.GetGehalt() * 1.3;
            }

            string stentgled = entgeld.ToString();

            string[] line = new string[] { person.GetName() + ", Ihr Entgeld beträgt: ", stentgled + " EURO" };
            GUIBuilder("IHR ENTGELD!", line, false);
            Console.ReadKey(true);
            Console.Clear();

            Weihnachtsgeld_Menu();
        }

        public static void GUIBuilder(string title, string[] lines,bool auswahl)
        {
            int maxLänge = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > maxLänge)
                {
                    maxLänge = lines[i].Length;
                }
                maxLänge += 8;
            }

            Console.SetWindowSize(maxLänge, lines.Length * 2 + 4);

            int titleSpace = (maxLänge - title.Length) / 2;
            SternchenSetzten(titleSpace);
            Console.Write(title);
            SternchenSetzten(titleSpace);
            Console.WriteLine();

            for (int i = 0; i < lines.Length; i++)
            {
                SternchenSetzten(1);
                Console.Write(" ");
                Console.Write(lines[i]);
                LeerzeichenSetzten(maxLänge - lines[i].Length - 2 - 1);
                SternchenSetzten(1);
                Console.WriteLine();
                LeereZeile(maxLänge);
            }

            SternchenSetzten(1);
            int cursleft = 0;
            int curstop = 0;

            if (auswahl)
            {
                Console.Write(" AUSWAHL: ");

                cursleft = Console.CursorLeft;
                curstop = Console.CursorTop;
                LeerzeichenSetzten(maxLänge - 10 - 2);
            }
            else
            {
                LeerzeichenSetzten(maxLänge -2);
            }
                SternchenSetzten(1);
                Console.WriteLine();
            LeereZeile(maxLänge);
            SternchenSetzten(maxLänge);
            if (auswahl)
            {
                Console.SetCursorPosition(cursleft, curstop);
            }
        }



        #region Sternchen und leerzeichen

        public static void LeereZeile(int maxLänge)
        {
            SternchenSetzten(1);
            LeerzeichenSetzten(maxLänge - 2);
            SternchenSetzten(1);
            Console.WriteLine();
        }

        #region Sternchen Setzten

        public static void SternchenSetzten(int s)
        {
            for (int i = 0; i < s; i++)
            {
                Console.Write("*");
            }
        }
        #endregion

        #region Leerzeichen Setzten

        public static void LeerzeichenSetzten(int s)
        {
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
        }
        #endregion
        #endregion
    }
}
