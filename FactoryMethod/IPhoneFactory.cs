namespace FactoryMethod
{
    public class IPhoneFactory : PhoneFactory
    {
        public override Phone Create()
        {
            return new IPhone();
        }
    }
}