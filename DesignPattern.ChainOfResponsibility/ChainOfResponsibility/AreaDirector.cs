using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.ViewModels;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye talep ettiği tutar ödendi";
                customerProcess.EmployeeName = "Bölge Müdürü  : Sercan ÖZTÜRK";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme tutarı Bölge Müdürünün  günlük ödeyebileceği limiti aştığı" +
                    " için işlem gerçekleştirelemedi.Müşterinin günlük max çekebileceği tutar 400.000 TL olup daha fazlası için" +
                    " birden fazla gün şubeye gelmesi gerekli";
                customerProcess.EmployeeName = "Bölge Müdürü  : Sercan ÖZTÜRK";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
