namespace SimpleFactory
{
    public class IPhone : Phone
    {
        public override void Call()
        {
            System.Console.WriteLine("Call by IPhone");
        }
    }
}