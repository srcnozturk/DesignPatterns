using DesignPattern.ObserverDesignPattern.DAL;
using System;

namespace DesignPattern.ObserverDesignPattern.ObserverPattern
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim dergimizin Mart Sayısı 1 Martta evinize ulaştıralacaktır, konular Jüpiter gezegeni ve Mars olacaktır"
            });
            context.SaveChanges();
        }
    }
}
