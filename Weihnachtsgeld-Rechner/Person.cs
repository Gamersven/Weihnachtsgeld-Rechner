using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    public class Person
    {
        public static double Age;
        public static double Gehalt;
        public static double Treue;

        // Person(string Personage, string Persongehalt, string Persontreue)
        // {
        //     this.Age = new double;
        //     this.Gehalt = double.Parse(Persongehalt);
        //     this.Treue = double.Parse(Persontreue);
        //}
        public static void SetAge(string Personage)
        {
            Age = double.Parse(Personage);
        }
        public static void SetGehalt(string Persongehalt)
        {
            Gehalt = double.Parse(Persongehalt);
        }
        public static void SetTreue(string Persontreue)
        {
            Treue = double.Parse(Persontreue);
        }
    }
}
