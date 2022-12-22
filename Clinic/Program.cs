using Clinic;

internal class Program
{
    //private string _name;
    //private string _description;
    //private string _type;
    
    public static void Main(string[] args)
    {
        Dentist dentist = new Dentist("Robert", "Shults");
        Therapist therapist = new Therapist("Larry", "Woodstock");
        Patient patient = new Patient("Andrew", "Larrington", "70");
        
        HealingPlan healingPlan = new HealingPlan("Tooth cure", patient);
        healingPlan.AppointDoctor(dentist);
        dentist.Heal();

        HealingPlan healingPlan1 = new HealingPlan("Reciept", patient);
        healingPlan1.AppointDoctor(therapist);
        therapist.Heal();

    }
}
