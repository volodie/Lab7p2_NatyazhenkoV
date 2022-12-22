using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class Therapist : IDoctor
    {
        private string _name;
        private string _surname;

        public Therapist(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void Heal()
        {
            Console.WriteLine("Subsribe a recipe ");
        }
    }
}
