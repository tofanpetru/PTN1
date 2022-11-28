using Prototype.Abstract;

namespace Prototype.Domain.Entities
{
    internal class Game : GamePrototype
    {
        private readonly string _name;
        private readonly bool _isAvailable;
        private readonly decimal _price;
        private readonly string _specs;

        public Game(string name, bool isAvailable, decimal price)
        {
            _name = name;
            _isAvailable = isAvailable;
            _price = price;
            _specs = "Spec 1, spec 2, spec 3, spec 4";
        }

        public override GamePrototype? Clone
        {
            get
            {
                string gameSpecs = GetGameSpec();
                Console.WriteLine($"Cloning game with name: {_name} ; specs: " + gameSpecs);

                return MemberwiseClone() as GamePrototype;
            }
        }

        private string GetGameSpec()
        {
            return _specs;
        }
    }
}
