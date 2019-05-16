using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weihnachtsgeld_Rechner
{
    public class Person
    {
        private string name;
        private double alter;
        private double gehalt;
        private double treue;

        public Person()
        {
            this.name = "";
            this.alter = 0;
            this.gehalt = 0;
            this.treue = 0;
        }

        public Person(string name, double alter, double gehalt, double treue)
        {
            this.name = name;
            this.alter = alter;
            this.gehalt = gehalt;
            this.treue = treue;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(double alter)
        {
            this.alter = alter;
        }
        public void SetGehalt(double gehalt)
        {
            this.gehalt = gehalt;
        }
        public void SetTreue(double treue)
        {
            this.treue = treue;
        }

        public string GetName()
        {
            return this.name;
        }
        public double GetAge()
        {
            return this.alter;
        }
        public double GetGehalt()
        {
            return this.gehalt;
        }
        public double GetTreue()
        {
            return this.treue;
        }
    }
}
