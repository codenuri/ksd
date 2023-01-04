using System;

// 주제 : static 생성자
// 1. 인자를 가질수 없고, 오직 한개만 만들수 있다. 단, 한번만 호출된다.
// 2. 클래스의 static 멤버에 접근할때 호출.
// 3. 객체를 생성하면 호출.
class Car
{
    public int speed = 0;
    public static int count = 10;   // static field 
                                    // => 객체당 한개가 아니라
                                    // => 모든 객체가 공유 합니다

    // 일반 생성자 : 객체를 만들때 마다 호출됩니다.
    public Car()
    {
        speed = 20;
        Console.WriteLine("Car()");

//      count = 20;
    }
    // static 클래스 : Car 타입에 대해서 최초에 1회만 호출됩니다.
    // => 용도 : static field 를 초기화 하기위해 사용
    // => 특징 : 접근지정자를 표기하지 않습니다
    static Car()
    {
        // 실행시간에 다양한 조사후에 결정된 값으로
        // static field를 초기화 하기 위해
        count = 30;

        Console.WriteLine("static Car()");
    }
}

class Program
{
    public static void Main()
    {
        // 1. 객체 생성안하면 static 생성자도 호출안됩니다. 단.. 
        //Car c1 = new Car();
        //Car c2 = new Car();

        // 2. 객체 생성은 안했지만 static field 접근하면 
        //    static 생성자 호출.
        int n = Car.count;
    }
}