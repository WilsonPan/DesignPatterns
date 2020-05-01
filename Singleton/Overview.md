# 定义

确保某个类只有一个实例

## 实现方式

### 饿汉式加载（线程安全）

```cs
public sealed class Singleton
{
    private static Singleton _instance = new Singleton();
    //将构造函数设置私有，外部不能new
    private Singleton() { }
    public static Singleton Instance => _instance;
}
```

等价于

```cs
public sealed class Singleton
{
    private static Singleton _instance;
    static Singleton()
    {
        _instance = new Singleton();
    }
    //将构造函数设置私有，外部不能new 
    private Singleton() { }
    public static Singleton Instance => _instance;
}
```

### 懒汉式加载

- 非线程安全

```cs
public sealed class Singleton
{
    private static Singleton _instance;
    private Singleton() { }
    public static Singleton Instance => _instance = _instance ?? new Singleton();
}
```

- 线程安全

1. Double Check

```cs
public sealed class Singleton
{
    private static readonly object _lock = new object();
    private static Singleton _instance;
    private Singleton()
    {
        Console.WriteLine("Singleton Constructor");
    }
    public static Singleton Instance
    {
        get
        {
            /// 避免走内核代码
            if (_instance != null) return _instance;

            lock (_lock)
            {
                if (_instance == null)
                {
                    var temp = new Singleton();
                    //确保_instance写入之前，Singleton已经初始化完成
                    System.Threading.Volatile.Write<Singleton>(ref _instance, temp);
                }
            }
            return _instance;
        }
    }
}
```

2. 借助Lazy

```cs
public sealed class Singleton
{
    private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton(), true);
    private Singleton()
    {
        Console.WriteLine("Singleton Constructor");
    }
    public static Singleton Instance => _instance.Value;
}
```