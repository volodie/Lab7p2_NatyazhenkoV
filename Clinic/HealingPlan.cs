using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class HealingPlan
    {
        private string _name;
        private string _description;
        private Patient _patient;
        private IDoctor _doctor;


        public HealingPlan(string name, Patient patient) : this(name, null, patient) { }
        public HealingPlan(string name, string description, Patient patient)
        {
            _name = name;
            _description = description;
            _patient = patient;

        }

        public void AppointDoctor(IDoctor doctor) => _doctor = doctor;
    }
}
