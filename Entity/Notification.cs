using SOLID.Interfaces;
using System;

namespace SOLID.Entity
{
    public class Notification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Correo enviado");
        }
    }
}