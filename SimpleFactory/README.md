### 定义

---

通过工厂类提供的方法，创建不同的派生类

通常创建的类都具有共同的基类/接口

### 优缺点

---

- 优点

客户端与具体的实现类解耦

- 缺点
  
新增产品需要修改原来工厂类的方法，不符合开闭原则

### 角色

---

- 客户端  --> 静态工厂，抽象产品
- 抽象产品 --> 具体产品
- 具体产品
- 静态工厂 --> 抽象产品，具体产品

### 代码

---

- 抽象产品

```cs
public abstract class Phone
{
    public abstract void Call();
}
```

- 具体产品
  
```cs
public class IPhone : Phone
{
    public override void Call()
    {
        System.Console.WriteLine("Call by IPhone");
    }
}
```

- 静态工厂
  
```cs
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
```

- 客户端

```cs
var phone = PhoneFactory.Create("IPhone");
phone.Call();
```