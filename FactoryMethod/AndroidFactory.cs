namespace FactoryMethod
{
    public class AndroidFactory : PhoneFactory
    {
        public override Phone Create()
        {
            return new AndroidPhone();
        }
    }
}