using Singleton.Domain.Enums;

namespace Singleton.Domain.Entities
{
    public class GamingProduct
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public GameType GameType { get; set; } = GameType.Unknown;
    }
}
