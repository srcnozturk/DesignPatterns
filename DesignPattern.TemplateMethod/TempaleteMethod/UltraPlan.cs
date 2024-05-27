namespace DesignPattern.TemplateMethod.TempaleteMethod
{
    public class UltraPlan :NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string PlanType(string planTpye)
        {
            return planTpye;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resulotion(string resulotion)
        {
            return resulotion;
        }
    }
}
