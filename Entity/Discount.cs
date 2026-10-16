using SOLID.Interfaces;
using System;

namespace SOLID.Entity
{
    public class Discount : ICalculateDiscount
    {

        public void CalculateDiscount(double price)
        {
            double finalPrice = price - (price * 0.10);
            Console.WriteLine($"Total: {finalPrice}");
        }
    }
}