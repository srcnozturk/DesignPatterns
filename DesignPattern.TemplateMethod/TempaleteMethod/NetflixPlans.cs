namespace DesignPattern.TemplateMethod.TempaleteMethod
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resulotion(string.Empty);
            Content(string.Empty);
        }
        public abstract string PlanType(string planTpye);
        public abstract int CountPerson(int countPerson);
        public abstract double Price(double price);
        public abstract string Resulotion(string resulotion);
        public abstract string Content(string content);

    }
}
