using System;

namespace SOLID.Entity
{
    public class OrderService
    {
        public void CreateOrder(string product, double price)
        {
            Console.WriteLine($"Pedido creado: {product}");
        }
    }
}