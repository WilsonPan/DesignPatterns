namespace AbstractFactory.Phone
{
    public class KirinCPU : PhoneAbstract.CPU
    {
        public override void Show()
        {
            System.Console.WriteLine("使用麒麟CPU");
        }
    }
}