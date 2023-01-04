// 10_method6-1
using System;

class Sample
{
    public static void f1() { }
    public void f2() { }
}

// static class : 모든 멤버가 static 멤버 인 경우 에 static 클래스로 만드는
//                것이 좋습니다.
//                
static class Sample2
{
    public static void f1() { }
    public static void f2() { }
}

class Program
{
    public static void Main()
    {
        // 핵심 1. 클래스안의 static method 는 객체가 없어도 클래스 이름으로 호출
        Sample.f1();

        // 핵심 2. static 이 아닌 instance method 는 객체 생성후 호출
        Sample sp = new Sample();
        sp.f2();

        // 핵심 3. static 클래스는 객체를 생성할수 없습니다.
//      Sample2 sp2 = new Sample2();

//      Math m = new Math();    // Math 의 모든 멤버는 static 입니다.
                                // Math 자체도 static class 입니다.
    }
}

