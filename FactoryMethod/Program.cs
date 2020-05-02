using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new IPhoneFactory().Create();
            phone.Call();

            phone = new AndroidFactory().Create();
            phone.Call();
            
            Console.WriteLine("Hello World!");
        }
    }
}
