namespace SimpleFactory
{
    public static class PhoneFactory
    {
        public static Phone Create(string name)
        {
            switch (name)
            {
                case "IPhone":
                    return new IPhone();
                default :
                    throw new System.NotImplementedException($"未实现【{name}】类型");
            }
        }
    }
}