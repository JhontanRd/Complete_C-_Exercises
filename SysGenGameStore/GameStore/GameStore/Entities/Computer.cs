using GameStore.Entities.Enums;
using GameStore.Entities.Exceptions;

namespace GameStore.Entities
{
    public class Computer : Product
    {
        public Brand Brand { get; set; }
        public int Storage { get; set; }
        public int Memory { get; set; }
        public string Processor { get; set; }

        public Computer(int id, string name, double price, int quantity, Brand brand, int storage, int memory, string processor)
            : base(id, name, price, quantity)
        {
            if (storage == 0 || storage < 0)
            { throw new DomainException("This value to storage is not valid!"); }

            if (memory == 0 || memory < 0)
            { throw new DomainException("This value to memory is not valid!"); }

            if (string.IsNullOrEmpty(processor) || string.IsNullOrWhiteSpace(processor))
            { throw new DomainException("The name or type of processor can not be empty!"); }

            Brand = brand;
            Storage = storage;
            Memory = memory;
            Processor = processor;
        }

        public override string ToString()
        {
            return base.ToString() + $" Product: {nameof(Computer)}, Brand: {Brand.ToString()}, Storage: {Storage}GB, Memory: {Memory}GB, Processor: {Processor}\n";
        }
    }
}
