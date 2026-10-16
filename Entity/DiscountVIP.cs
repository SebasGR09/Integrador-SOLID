using SOLID.Interfaces;
using System;

namespace SOLID.Entity
{
    public class DiscountVIP : ICalculateDiscount
    {
        public void CalculateDiscount(double price)
        {
            double finalPrice = price - (price * 0.30);
            Console.WriteLine($"Total: {finalPrice}");
        }
    }
}