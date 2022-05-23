using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Kalitim
{
    public class Sporcu
    {
        private string name;
        private string surname;
        private int age;
        private string position;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
