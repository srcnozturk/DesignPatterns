using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.ViewModels;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAsistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye talep ettiği tutar ödendi";
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı : Sercan ÖZTÜRK";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover is not null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme tutarı Şube Müdür Yardımcısının günlük ödeyebileceği limiti aştığı" +
                    " için işlem şube müdürüne yönlendirildi";
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı : Sercan ÖZTÜRK";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
