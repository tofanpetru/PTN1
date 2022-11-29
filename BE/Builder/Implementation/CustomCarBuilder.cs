using Builder.Domain.Entities;
using Builder.Domain.Enums;

namespace Builder.Implementation
{
    public class CustomGameBuilder
    {
        private readonly Game _game;

        public CustomGameBuilder()
        {
            _game = new Game();
        }

        public CustomGameBuilder Name(string name)
        {
            _game.Name = name;
            return this;
        }

        public CustomGameBuilder Price(decimal price)
        {
            _game.Price = price;
            return this;
        }

        public CustomGameBuilder Category(GameType gameType)
        {
            _game.Category = gameType;
            return this;
        }

        public Game Build()
        {
            return _game;
        }
    }
}
