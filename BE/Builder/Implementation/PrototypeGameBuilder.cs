using Builder.Abstract;
using Builder.Domain.Entities;
using Builder.Domain.Enums;

namespace Builder.Implementation
{
    public class PrototypeGameBuilder : GameProductBuilder
    {
        public override GameProductBuilder BuildName()
        {
            Game.Name = "Prototype 2";
            return this;
        }

        public override GameProductBuilder BuildPrice()
        {
            Game.Price = 115;
            return this;
        }

        public override GameProductBuilder BuildIsMultiplayer()
        {
            Game.IsMultiplayer = false;
            return this;
        }

        public override GameProductBuilder BuildGameType()
        {
            Game.Category = GameType.Unknown;
            return this;
        }
    }
}
