using DesignPattern.ObserverDesignPattern.DAL;
using System;

namespace DesignPattern.ObserverDesignPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode="DERGIMART",
                DiscountAmount=35,
                DiscountCodeStatus=true
            });
            context.SaveChanges();
        }
    }
}
