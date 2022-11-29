using Builder.Abstract;
using Builder.Domain.Entities;
using Builder.Domain.Enums;
using Builder.Implementation;

namespace Builder.Application.ExtensionMethods
{
    public static class BuildExtensions
    {
        public static Game BuildGameProduct(GameProductBuilder gameProductBuilder)
        {
            return gameProductBuilder
                .Construct()
                .Build();
        }

        public static Game BuildGameProductStepByStep(GameProductBuilder gameProductBuilder)
        {
            return gameProductBuilder
                .BuildName()
                .BuildPrice()
                .BuildIsMultiplayer()
                .BuildGameType()
                .Build();
        }

        public static Game BuildCustomGameProduct(CustomGameBuilder customGameBuilder)
        {
            return customGameBuilder
                .Name("League of Legends")
                .Price(0)
                .Category(GameType.Action)
                .Build();
        }
    }
}
