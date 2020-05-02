namespace FactoryMethod
{
    public class AndroidPhone : Phone
    {
        public override void Call()
        {
            System.Console.WriteLine("Call by Android");
        }
    }
}