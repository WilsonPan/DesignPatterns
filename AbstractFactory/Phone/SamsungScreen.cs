namespace AbstractFactory.Phone
{
    public class SamsungScreen : PhoneAbstract.Screen
    {
        public override void Show()
        {
            System.Console.WriteLine("使用三星屏幕");
        }
    }
}