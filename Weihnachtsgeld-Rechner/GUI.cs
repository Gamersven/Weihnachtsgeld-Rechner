using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    class GUI
    {






        public static void Title(string title, int maxLänge)
        {
            int titleSpace = (maxLänge - title.Length) / 2;
            SternchenSetzten(titleSpace);
            Console.Write(title);
            SternchenSetzten(titleSpace);
            Console.WriteLine();
        }

        public static void NormaleZeile(string Input, int maxLänge)
        {
            LeereZeile(maxLänge);
            SternchenSetzten(1);
            Console.Write(" " + Input);
            LeerzeichenSetzten(maxLänge - Input.Length - 2 - 1);
            Console.WriteLine("*");
        }

        public static void Auswahl(int maxLänge)
        {
            int CursorLeft = Console.CursorLeft;
            int CursorTop = Console.CursorTop;

            Console.WriteLine("* AUSWAHL: ");
            LeerzeichenSetzten(maxLänge - 10 - 2);

        }
        public static void Ende(int maxLänge)
        {
            LeereZeile(maxLänge);
            SternchenSetzten(maxLänge);

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
