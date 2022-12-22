using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient
    {
        private string _name;
        private string _surname;
        private string _age;
        private HealingPlan _healingtPlan;

        public Patient(string name, string surname, string age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
        }

        public void GeHealingPlan(HealingPlan healingPlan) => _healingtPlan = healingPlan;

    }
}
