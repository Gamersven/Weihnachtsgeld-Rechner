﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Weihnachtsgeld - Rechner";
            Weihnachtsgeld_Menu();
        }

        public static void Weihnachtsgeld_Menu()
        {
            double ge;
            double al;
            double zif;

            string[] lines = new string[] {
                "Geben sie Ihr Gehalt, danch Ihr Alter","und zuletzt die Zeit in der Sie zu der Firma gehören an! "
            };
            GUIBuilder("DEIN WEIHNACHTSGELD!",lines);

            ge = int.Parse(Console.ReadLine());
            GUIBuilder("DEIN WEIHNACHTSGELD!", lines);
            al = int.Parse(Console.ReadLine());
            GUIBuilder("DEIN WEIHNACHTSGELD!", lines);
            zif = int.Parse(Console.ReadLine());

            Weihnachtsgeld_Rechner(ge,al,zif);


        }



        private static void Weihnachtsgeld_Rechner(double gehalt, double alter, double zifirma)
        {
            double entgeld = new double();

            if (alter >= 50 & zifirma >= 20)
            {
                entgeld = gehalt * 1.45;
            }
            else if(zifirma >= 15 | alter >= 55)
            {
                entgeld = gehalt * 1.4;
            }
            else
            {
                entgeld = gehalt * 1.3;
            }

            string stentgled = entgeld.ToString();

            string[] line = new string[] { "Ihr Entgeld beträgt: ", stentgled + " EURO" };
            GUIBuilder("IHR ENTGELD!", line);
            Console.ReadKey(true);
        }

        public static void GUIBuilder(string title, string[] lines)
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
            Console.Write(" AUSWAHL: ");
            int cursleft = Console.CursorLeft;
            int curstop = Console.CursorTop;
            LeerzeichenSetzten(maxLänge - 10 - 2);
            SternchenSetzten(1);
            Console.WriteLine();
            LeereZeile(maxLänge);
            SternchenSetzten(maxLänge);
            Console.SetCursorPosition(cursleft, curstop);
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
