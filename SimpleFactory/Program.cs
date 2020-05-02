using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = PhoneFactory.Create("IPhone");
            phone.Call();

            phone = PhoneFactory.Create("AndroidPhone");
            phone.Call();
            
            Console.WriteLine("Hello World!");
        }
    }
}
