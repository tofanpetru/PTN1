using Prototype.Abstract;

namespace Prototype.Application
{
    class ProductMenu
    {
        private readonly Dictionary<string, GamePrototype> _products = new();

        public GamePrototype this[string name]
        {
            get => _products[name];
            set => _products.Add(name, value);
        }
    }
}
