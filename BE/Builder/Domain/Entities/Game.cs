using Builder.Domain.Enums;

namespace Builder.Domain.Entities
{
    public class Game
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsMultiplayer { get; set; }
        public GameType Category { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nIsMultiplayer: {IsMultiplayer}\nCategory: {Category}\n";
        }
    }
}
