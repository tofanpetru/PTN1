using Builder.Abstract;
using Builder.Domain.Entities;
using Builder.Domain.Enums;

namespace Builder.Implementation
{
    public class CsGameBuilder : GameProductBuilder
    {
        public override GameProductBuilder BuildName()
        {
            Game.Name = "Cs Go";
            return this;
        }

        public override GameProductBuilder BuildPrice()
        {
            Game.Price = 14;
            return this;
        }

        public override GameProductBuilder BuildIsMultiplayer()
        {
            Game.IsMultiplayer = true;
            return this;
        }

        public override GameProductBuilder BuildGameType()
        {
            Game.Category = GameType.Action;
            return this;
        }
    }
}
