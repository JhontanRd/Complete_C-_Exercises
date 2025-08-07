

using GameStore.Entities.Enums;
using GameStore.Entities.Exceptions;

namespace GameStore.Entities
{
    public class Accessory : Product
    {
        public AccessoryType AccessoryType { get; set; }
        public string Compatibility { get; set; }

        public Accessory(int id, string name, double price, int quantity, AccessoryType accessoryType, string compatibility)
            : base(id, name, price, quantity)
        {
            if (string.IsNullOrEmpty(compatibility) || string.IsNullOrWhiteSpace(compatibility))
            { throw new DomainException("The compatibility must be informed to add a new accessory."); }

            AccessoryType = accessoryType;
            Compatibility = compatibility;
        }

        public override string ToString()
        {
            return base.ToString() + $" Product: {nameof(Accessory)}, Type: {AccessoryType.ToString()}, Compatibility: {Compatibility}\n";
        }
    }
}
