using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Surgeon : IDoctor
    {
        private string _name;
        private string _surname;

        public Surgeon(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void Heal()
        {
            Console.WriteLine("You will go to a surgical operation");
        }
    }
}
