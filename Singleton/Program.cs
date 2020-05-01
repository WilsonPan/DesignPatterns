using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(1, 50, (i, state) =>
            {
                var instance = Singleton.Instance;
            });
            Console.WriteLine("Finish");
        }
    }
}
