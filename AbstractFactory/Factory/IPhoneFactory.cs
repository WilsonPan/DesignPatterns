using AbstractFactory.PhoneAbstract;

namespace AbstractFactory.Factory
{
    public class IPhoneFactory : PhoneFactory
    {
        public override CPU GetCPU()
        {
            return new Phone.ASeriesCPU();
        }

        public override Screen GetScreen()
        {
            return new Phone.SamsungScreen();
        }
    }
}