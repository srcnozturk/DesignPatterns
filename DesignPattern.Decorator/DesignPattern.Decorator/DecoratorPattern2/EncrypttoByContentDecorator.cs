using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncrypttoByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncrypttoByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }
        public void SendMessageEncryptoContent(Message message)
        {
            message.MessageSender   = "İnsan Kaynakları";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent  = "Saat 17:00'de Publish yapılacak";
            message.MessageSubject  = "Publish";
            string data             = "";
            data                    = message.MessageSubject;
            char[] chars            = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageEncryptoContent(message);
        }
    }
}
