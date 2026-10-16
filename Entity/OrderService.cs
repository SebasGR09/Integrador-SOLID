using SOLID.Interfaces;
using System;

namespace SOLID.Entity
{
    public class OrderService
    {
        // Inversion de dependencias
        private readonly ICalculateDiscount _discount;
        private readonly INotification _notification;
        private readonly IOrderSaved _orderSaved;

        private double _price;


        // Constructores

        public OrderService(ICalculateDiscount discount, INotification notification, IOrderSaved orderSaved)
        {
            this._discount = discount;
            this._notification = notification;
            this._orderSaved = orderSaved;
        }


        // Metodos en base a las dependencias

        public void CreateOrder(string product, double price)
        {
            this._price = price;
            Console.WriteLine($"Pedido creado: {product}");
        }

        public void DiscountOrder()
        {
            _discount.CalculateDiscount(_price);
        }

        public void Notification()
        {
            _notification.SendNotification();
        }

        public void OrderSaved()
        {
            _orderSaved.SendOrderSaved();
        }
    }
}