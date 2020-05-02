namespace AbstractFactory.Phone
{
    public class ASeriesCPU : PhoneAbstract.CPU
    {
        public override void Show()
        {
            System.Console.WriteLine("使用A系列CPU");
        }
    }
}