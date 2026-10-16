using SOLID.Interfaces;
using System;

namespace SOLID.Entity
{
    public class OrderSaved: IOrderSaved
    {
        public void SendOrderSaved()
        {
            Console.WriteLine("Pedido guardado en la base de datos");
        }
    }
}