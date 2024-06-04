using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncrypttoBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context=new Context();
        public EncrypttoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageEncryptoSubject(Message message)
        {
            message.MessageSender   = "İnsan Kaynakları";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent  = "Saat 12:00'de Toplantı var";
            message.MessageSubject  = "Toplantı";
            string data             = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageEncryptoSubject(message);
        }
    }
}
