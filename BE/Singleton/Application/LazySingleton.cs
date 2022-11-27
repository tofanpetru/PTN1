namespace Singleton.Application
{
    public sealed class LazySingleton<T> where T : new()
    {
        private static readonly Lazy<T> _instance;

        static LazySingleton() => _instance = new Lazy<T>(() => new T());

        LazySingleton() { }

        public static T Instance => _instance.Value;
    }
}
