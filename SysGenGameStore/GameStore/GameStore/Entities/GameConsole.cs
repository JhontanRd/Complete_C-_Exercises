using GameStore.Entities.Enums;
using GameStore.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Entities
{
    public class GameConsole : Product
    {
        public string Manufacturer { get; set; }
        public Platform Platform { get; set; } 
        public string Model { get; set; }
       
        public GameConsole(int id, string name, double price, int quantity, string manufacturer, Platform platform, string model)
            : base(id, name, price, quantity)
        {
            if (string.IsNullOrWhiteSpace(manufacturer) || string.IsNullOrEmpty(manufacturer))
            { throw new DomainException("The name of manufacturer can not be empty!"); }

            if (string.IsNullOrWhiteSpace(model) || string.IsNullOrEmpty(model))
            { throw new DomainException("The name of model can not be empty!"); }

            Platform = platform;
            Manufacturer = manufacturer;
            Model = model;
        }

        public override string ToString()
        {
            return base.ToString() + $" Product: {nameof(GameConsole)}, Manufacturer: {Manufacturer}, Platform: {Platform.ToString()}, Model: {Model}\n";
        }
    }
}
