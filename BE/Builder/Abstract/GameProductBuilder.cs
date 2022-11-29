using Builder.Domain.Entities;

namespace Builder.Abstract
{
    public abstract class GameProductBuilder
    {
        protected Game Game;
        protected GameProductBuilder() => Game = new Game();

        public abstract GameProductBuilder BuildName();
        public abstract GameProductBuilder BuildPrice();
        public abstract GameProductBuilder BuildIsMultiplayer();
        public abstract GameProductBuilder BuildGameType();

        public GameProductBuilder Construct()
        {
            BuildName();
            BuildPrice();
            BuildIsMultiplayer();
            BuildGameType();

            return this;
        }

        public Game Build()
        {
            return Game;
        }
    }
}
