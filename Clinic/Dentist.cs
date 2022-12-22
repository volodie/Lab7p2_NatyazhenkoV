using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Dentist : IDoctor
    {
        private string _name;
        private string _surname;

        public Dentist(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void Heal()
        {
            Console.WriteLine("You must cure the tooth ");

        }
    }
}
