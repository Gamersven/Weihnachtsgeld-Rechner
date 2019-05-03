using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    public class Person
    {
        private double Age;
        private double Gehalt;
        private double Treue;

        public Person()
        {
            this.Age = 0;
            this.Gehalt = 0;
            this.Treue = 0;
        }

        public Person(double Personage, double Persongehalt, double Persontreue)
        {
             this.Age = Personage;
             this.Gehalt = Persongehalt;
             this.Treue = Persontreue;
        }

        public void SetAge(string Personage)
        {
            Age = double.Parse(Personage);
        }
        public void SetGehalt(string Persongehalt)
        {
            Gehalt = double.Parse(Persongehalt);
        }
        public void SetTreue(string Persontreue)
        {
            Treue = double.Parse(Persontreue);
        }

        public double getAge()
        {
            return this.Age;
        }
        public double getGehalt()
        {
            return this.Gehalt;
        }
        public double getTreue()
        {
            return this.Treue;
        }
    }
}
