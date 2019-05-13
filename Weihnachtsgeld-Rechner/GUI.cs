using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    class GUI
    {
        public static int maxLänge;

        public static void GUIBuilder(string title, string[] lines, bool auswahl)
        {
            maxLänge = 0;
            Console.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > maxLänge)
                {
                    maxLänge = lines[i].Length;
                }
                maxLänge += 8;
            }

            Console.SetWindowSize(maxLänge, lines.Length * 2 + 4);

            Title(title);

            for (int i = 0; i < lines.Length; i++)
            {
                NormaleZeile(lines[i]);
            }

            int cursleft = 8;
            int curstop = 0;

            if (auswahl)
            {
                curstop = Console.CursorTop;
                Auswahl();
                Ende();
                Console.SetCursorPosition(cursleft, curstop);
            }
            else
            {
                LeereZeile();
                Ende();
            }
        }

        public static void Title(string title)
        {
            int titleSpace = (maxLänge - title.Length) / 2;
            SternchenSetzten(titleSpace);
            Console.Write(title);
            SternchenSetzten(titleSpace);
            Console.WriteLine();
        }

        public static void NormaleZeile(string Input)
        {
            LeereZeile();
            SternchenSetzten(1);
            Console.Write(" " + Input);
            LeerzeichenSetzten(maxLänge - Input.Length - 2 - 1);
            Console.WriteLine("*");
        }

        public static void Auswahl()
        {
            int CursorLeft = Console.CursorLeft;
            int CursorTop = Console.CursorTop;

            Console.WriteLine("* AUSWAHL: ");
            LeerzeichenSetzten(maxLänge - 10 - 2);

        }
        public static void Ende()
        {
            LeereZeile();
            SternchenSetzten(maxLänge);

        }

        #region Sternchen und leerzeichen

        public static void LeereZeile()
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
            StringBuilder leerzeichen = new StringBuilder();

            for (int i = 0; i < s; i++)
            {
                leerzeichen.Append(" ");
            }

            Console.Write(leerzeichen);
        }
        #endregion
        #endregion


    }
}
