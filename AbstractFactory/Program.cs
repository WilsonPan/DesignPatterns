using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------  IPhone 手机  --------");
            var iphoneFactory = new Factory.IPhoneFactory();
            iphoneFactory.GetScreen().Show();
            iphoneFactory.GetCPU().Show();

            Console.WriteLine(Environment.NewLine + "--------  HUAWEI 手机  --------");
            var hwFactory = new Factory.HWPhoneFactory();
            hwFactory.GetScreen().Show();
            hwFactory.GetCPU().Show();

        }
    }
}
