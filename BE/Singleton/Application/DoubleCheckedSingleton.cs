namespace Singleton.Application
{
    public sealed class DoubleCheckedSingleton<T> where T : new()
    {
        private static volatile object? _instance;
        private static readonly object _syncRoot = new();

        DoubleCheckedSingleton() { }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        _instance ??= new T();
                    }
                }

                return (T)_instance;
            }
        }
    }
}
