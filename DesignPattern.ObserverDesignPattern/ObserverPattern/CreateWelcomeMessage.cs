using DesignPattern.ObserverDesignPattern.DAL;
using System;

namespace DesignPattern.ObserverDesignPattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage()
            {
                NameSurName = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize kayıt olduğunuz için çok teşekkür ederiz, dergilerimize web sitemizden ulaşabilirsiniz"
            });
            context.SaveChanges();
        }
    }
}
