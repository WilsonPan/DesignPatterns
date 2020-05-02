using AbstractFactory.PhoneAbstract;

namespace AbstractFactory.Factory
{
    public class HWPhoneFactory : PhoneFactory
    {
        public override CPU GetCPU()
        {
            return new Phone.KirinCPU();
        }

        public override Screen GetScreen()
        {
            return new Phone.LGScreen();
        }
    }
}