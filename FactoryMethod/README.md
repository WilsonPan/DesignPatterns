### 定义

---

定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类

### 优缺点

---

- 优点

针对简单工厂不容易扩展，工厂方法将实例化延迟到子类工厂，从而提供扩展

- 缺点
  
每次新增产品都需要添加工厂和具体产品类，增加系统复杂性

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

```cs
public class AndroidPhone : Phone
{
    public override void Call()
    {
        System.Console.WriteLine("Call by Android");
    }
}
```

- 抽象工厂
  
```cs
public abstract class PhoneFactory
{
    public abstract Phone Create();
}
```

- 具体工厂
  
```cs
public class IPhoneFactory : PhoneFactory
{
    public override Phone Create()
    {
        return new IPhone();
    }
}
```

```cs
public class AndroidFactory : PhoneFactory
{
    public override Phone Create()
    {
        return new AndroidPhone();
    }
}
```

- 客户端

```cs
Phone phone = new IPhoneFactory().Create();
phone.Call();

phone = new AndroidFactory().Create();
phone.Call();
```

### 简单工厂 VS 工厂方法

假设现在需要扩展手机产品，增加鸿蒙OS手机

- 简单工厂

1. 增加具体手机类 ```HarmonyPhone```
2. 修改静态工厂方法增加HarmonyPhone判断（违反开闭原则）

- 工厂方法

1. 增加具体手机类 ```HarmonyPhone```
2. 增加具体工厂类 ```HarmonyFactory```

### 总结
  
工厂方法模式是典型的解耦框架，通过增加抽象工厂，客户端与具体产品解耦，抽象工厂与具体产品解构

符合迪米特法则，不需要知道具体产品如何构造

符合依赖倒置原则，只依赖产品类的抽象

符合里氏替换原则，父类出现的地方都可以用子类替换，因为没有破坏继承体系

当然最重要复合开闭原则，当需要扩展产品时，并不需要改动原来代码，只需增加新的具体产品类，具体工厂类