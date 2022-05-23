using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Kalitim
{
    public class Futbolcu : Sporcu
    {
        private string country;
        private string teamName;
        private string leage;

        public string Country
        { 
            get { return country; } 
            set { country = value; }
        }
        public string TeamName
        {
            get { return teamName; } 
            set { teamName = value; } 
        }

        public string Leage
        {
            get { return leage; }
            set { leage = value; }
        }
    }
}
