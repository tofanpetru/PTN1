using BetterConsoleTables;
using Singleton.Domain.Entities;

namespace Singleton.Application.ExtensionMethods
{
    public static class SingletonExtensions
    {
        public static void CheckSingleton(GamingProduct firstInstance, GamingProduct secondInstance)
        {
            firstInstance.Price++;
            Table table = new("firstInstance.price", "secondInstance.price");
            table.AddRow(firstInstance.Price, secondInstance.Price);

            Console.Write(table.ToString());
            Console.WriteLine("\nThe product price are equal in both instances of singleton: {0}", firstInstance.Price == secondInstance.Price);
        }

        public static void CheckSingletonInMultithreadingMode(int threadsCount = 10)
        {
            Thread[] threads = new Thread[threadsCount];
            GamingProduct[] products = new GamingProduct[threadsCount];
            EventWaitHandle threadsFinishedEvent = new(false, EventResetMode.AutoReset);
            using Barrier startBarrier = new(threadsCount), finishBarrier = new(threadsCount, barrier => threadsFinishedEvent.Set());

            for (int index = 0; index < threadsCount; index++)
            {
                threads[index] = new Thread(threadIndex =>
                {
                    // Synchronizes all threads before start.
                    startBarrier.SignalAndWait();
                    try
                    {
                        int currentIndex = (int)threadIndex;
                        products[currentIndex] = currentIndex >= threadsCount / 2 ? DoubleCheckedSingleton<GamingProduct>.Instance : LazySingleton<GamingProduct>.Instance;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        // Synhronizes all threads before finish.
                        finishBarrier.SignalAndWait();
                    }
                });
                threads[index].Start(index);
            }

            threadsFinishedEvent.WaitOne();
            var lazySingletonInstance = LazySingleton<GamingProduct>.Instance;
            var doubleCheckedSingletonInstance = DoubleCheckedSingleton<GamingProduct>.Instance;

            //increment price of created instances and then it should be compared with all different threads instances
            lazySingletonInstance.Price++;
            doubleCheckedSingletonInstance.Price++;


            Table table = new("ThreadNumber", "Product price");
            for (int i = 0; i < products.Length; i++)
            {
                table.AddRow(i, products[i].Price);
            }
            Console.Write(table.ToString());


            Console.WriteLine($"\nThe product price are equal in both instances of singleton: "
                              + products.Take(threadsCount / 2).All(m => m.Price == lazySingletonInstance.Price));
            Console.WriteLine($"\nThe product price are equal in both instances of singleton: "
                              + products.Skip(threadsCount / 2).All(m => m.Price == lazySingletonInstance.Price));
        }
    }
}
