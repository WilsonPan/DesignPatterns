### 定义

---

为创建一组相关或相互依赖的对象提供一个接口，而且无须指定它们的具体类

抽象工厂是工厂方法的升级版，处理的多个产品，若只有一个产品，变化成工厂方法

### 优缺点

---

- 优点

1. 高层模块不依赖具体实现，依赖是抽象类/接口
2. 封装性，具体构造都封装在具体实现工厂，高层模块不需要知道如何创建
3. 产品等级容易扩展（例如条件一个小米手机，只需要添加XiaoMiFactory和具体相应的产品族）
   
- 缺点
  
1. 产品族扩展非常困难（例如需要添加RAM，抽象工厂，所有实现工厂都需要修改，违反开闭原则）


### 角色

---

- 客户端  --> 抽象工厂，具体工厂， 抽象产品
- 抽象产品 --> 具体产品
- 具体产品
- 抽象工厂 --> 抽象产品
- 具体工厂 --> 抽象产品，具体产品

### 代码

---

- 抽象产品

```cs
public abstract class Screen
{
    public abstract void Show();
}
```

```cs
public abstract class CPU
{
    public abstract void Show();
}
```

- 具体产品
  
```cs
public class SamsungScreen : PhoneAbstract.Screen
{
    public override void Show()
    {
        System.Console.WriteLine("使用三星屏幕");
    }
}
```

```cs
public class LGScreen : PhoneAbstract.Screen
{
    public override void Show()
    {
        System.Console.WriteLine("使用LG屏幕");
    }
}
```

- 抽象工厂
  
```cs
public abstract class PhoneFactory
{
    public abstract PhoneAbstract.Screen GetScreen();

    public abstract PhoneAbstract.CPU GetCPU();
}
```

- 具体工厂
  
```cs
public class IPhoneFactory : PhoneFactory
{
    public override CPU GetCPU()
    {
        return new Phone.ASeriesCPU();
    }

    public override Screen GetScreen()
    {
        return new Phone.SamsungScreen();
    }
}
```

```cs
public class HWPhoneFactory : PhoneFactory
{
    public override CPU GetCPU()
    {
        return new Phone.KirinCPU();
    }

    public override Screen GetScreen()
    {
        return new Phone.LGScreen();
    }
}
```

- 客户端

```cs
Console.WriteLine("--------  IPhone 手机  --------");
var iphoneFactory = new Factory.IPhoneFactory();
iphoneFactory.GetScreen().Show();
iphoneFactory.GetCPU().Show();

Console.WriteLine(Environment.NewLine + "--------  HUAWEI 手机  --------");
var hwFactory = new Factory.HWPhoneFactory();
hwFactory.GetScreen().Show();
hwFactory.GetCPU().Show();
```

### 总结
  
抽象工厂是工厂方法的升级版，适合一个对象族（或是一组没有任何关系的对象）都有相同的约束，则可以使用抽象工厂模式