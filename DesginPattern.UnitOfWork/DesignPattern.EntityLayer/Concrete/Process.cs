namespace DesignPattern.EntityLayer.Concrete
{
    public class Process
    {
        public int ProcessId { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public decimal Amount { get; set; }
    }
}
