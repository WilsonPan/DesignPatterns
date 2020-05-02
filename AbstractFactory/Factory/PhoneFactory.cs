namespace AbstractFactory.Factory
{
    public abstract class PhoneFactory
    {
        public abstract PhoneAbstract.Screen GetScreen();

        public abstract PhoneAbstract.CPU GetCPU();
    }
}