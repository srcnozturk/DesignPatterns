using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.ViewModels;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=req.Amount.ToString();
                customerProcess.Name=req.Name;
				customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye talep ettiği tutar ödendi";
                customerProcess.EmployeeName = "Veznedar : Sercan ÖZTÜRK";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover is not null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
				customerProcess.Description = "Para çekme tutarı Veznedarın günlük ödeyebileceği limiti aştığı" +
					" için işlem şube müdür yardımcısına yönlendirildi";
				customerProcess.EmployeeName = "Veznedar : Sercan ÖZTÜRK";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
