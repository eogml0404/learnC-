using System;


class Person
{
    public string Name;
    public int Weight;

    public void Eat()
    {
        Console.WriteLine(Name + "가 식사를 합니다.");
    }

    //오버 로딩
    public void Intro(string name)
    {
        Name = name;
        Console.WriteLine("이름은 " + Name + "입니다.");

    }

    public void Intro(string name, int weight)
    {
        Name = name;
        Weight = weight;
        Console.WriteLine("이름은 " + Name + "이고, 몸무게는 " + Weight + "입니다.");

    }

    //클래스의 종료 - 소멸자 
    ~Person()
    {
        Console.WriteLine(Name + "가 사라집니다.");
    }
}

class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot : Robot
{
    public void Clean()
    {
        Console.WriteLine("로봇이 청소를 합니다.");
    }

    //오버 라이딩
    public void Move()
    {
        Console.WriteLine("청소 로봇이 움직입니다.");
    }
}

class Cat
{
    private string name;

    //private는 외부에서 접근 x -> 접근하게 하는 메소드가 getter, setter

    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Person p1 = new Person();
        p1.Name = "서준";
        p1.Eat();

        p1.Intro("서준", 123);

        CleanRobot cr = new CleanRobot();
        cr.Move();
        cr.Clean();

        Cat mycat = new Cat();
        mycat.SetName("냐옹");
        Console.WriteLine(mycat.GetName());
    }
}