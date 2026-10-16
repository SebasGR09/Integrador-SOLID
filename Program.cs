using SOLID.Entity;
using SOLID.Interfaces;
using System;

namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ICalculateDiscount discount = new Discount();
            ICalculateDiscount discountVIP = new DiscountVIP();

            INotification notification = new Notification();

            IOrderSaved orderSaved = new OrderSaved();

            
            
            OrderService orden = new OrderService(discountVIP, notification, orderSaved);

            orden.CreateOrder("Manga", 5000);

            orden.DiscountOrder();

            orden.Notification();
            
            orden.OrderSaved();
        }
    }
}