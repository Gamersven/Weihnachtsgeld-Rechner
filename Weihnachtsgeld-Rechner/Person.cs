using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    public class Person
    {
        private string Name;
        private double Age;
        private double Gehalt;
        private double Treue;

        public Person()
        {
            this.Name = "";
            this.Age = 0;
            this.Gehalt = 0;
            this.Treue = 0;
        }

        public Person(string Personname, double Personage, double Persongehalt, double Persontreue)
        {
            this.Name = Personname;
            this.Age = Personage;
            this.Gehalt = Persongehalt;
            this.Treue = Persontreue;
        }
        public void SetName(string Personname)
        {
            Name = Personname;
        }
        public void SetAge(double Personage)
        {
            Age = Personage;
        }
        public void SetGehalt(double Persongehalt)
        {
            Gehalt = Persongehalt;
        }
        public void SetTreue(double Persontreue)
        {
            Treue = Persontreue;
        }

        public string GetName()
        {
            return this.Name;
        }
        public double GetAge()
        {
            return this.Age;
        }
        public double GetGehalt()
        {
            return this.Gehalt;
        }
        public double GetTreue()
        {
            return this.Treue;
        }
    }
}
