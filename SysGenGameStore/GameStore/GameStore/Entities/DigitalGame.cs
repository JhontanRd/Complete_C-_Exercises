using GameStore.Entities.Enums;
using GameStore.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Entities
{
    public class DigitalGame : Product
    {
        public Platform Platform { get; set; }
        public GameGenre GameGenre { get; set; }
        public int AgeRating { get; set; }
        public int Size { get; set; }

        public DigitalGame(int id, string name, double price, int quantity, Platform platform, GameGenre gameGenre, int ageRating, int size)
            : base(id, name, price, quantity)
        {
            if (ageRating <= 0)
            { throw new DomainException("The age must be bigger of zero!"); }
            
            if (size <= 0)
            { throw new DomainException("The size must be bigger of zero!"); }

            Platform = platform;
            GameGenre = gameGenre;
            AgeRating = ageRating;
            Size = size;
        }
        public override string ToString()
        {
            return base.ToString() + $" Product: {nameof(DigitalGame)}, Platform: {Platform.ToString()}, Genre: {GameGenre.ToString()}, Age Rating: {AgeRating}, Size: {Size}GB.\n";
        }
    }
}
