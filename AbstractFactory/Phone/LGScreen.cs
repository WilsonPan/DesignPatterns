namespace AbstractFactory.Phone
{
    public class LGScreen : PhoneAbstract.Screen
    {
        public override void Show()
        {
            System.Console.WriteLine("使用LG屏幕");
        }
    }
}