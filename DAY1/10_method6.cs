using System;

// 확장 메소드

// 이미 만들어진 클래스가 있다.
class Car
{
    public void Go() { Console.WriteLine("Car Go"); }
}

// 그런데, 이미 만들어진 클래스 안에 새로운 메소드를 추가하고 싶다.
// C++ : 할수 없다!
// C#, swift : 가능하다.

// 확장 메소드(extension method) : 기존 클래스 코드는 수정하지 않고
//                              메소드를 추가하는 문법
//                              LINQ 의 핵심 원리!!
// 1. static class 로 작성해야 하고
// 2. 1번재 인자는 반드시 "this Car" 가 되어야 합니다.
static class CarExtension  // 클래스 이름은 자유롭게 만들어도 됩니다.
{
    public static void Stop(this Car c) // this가 핵심
    {
        Console.WriteLine("Car Stop");

        // c를 사용해서 멤버 접근 은 가능하지만 public 멤ㅂ만 가능
    }
}
class Program
{
    public static void Main()
    {
        Car c = new Car();
        c.Go();
        c.Stop();  // CarExtension.Stop(c);
    }
}