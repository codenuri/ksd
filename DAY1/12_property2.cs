using System;

// 주제 : property
// ildasm 으로 확인
// 1. 사용시에는 필드처럼 보이지만 구현시에는 메서드 처럼 만드는 코드.

// 프라퍼티 원리
// => C# 컴파일러가 프라퍼티 코드를 보고
// => set_Gear()/get_Gear() 메소드를 생성한것!!


class Bike
{
    private int gear = 0;

    // 프라퍼티(Property)
    // 1. 만드는 사람은 "메소드" 처럼 만들게 됩니다.
    // 2. 사용하는 사람은 "필드" 처럼 사용하게 됩니다.
    public int Gear
    {
        get { return gear; }
        set { if ( value > 0 ) gear = value; }
    }

//    public int get_Gear() { return gear; }

    public void Go() { }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        b.Gear = 10; // set 구문 호출
                     // 10 이 set 구문의 value 로 전달

        int n = b.Gear;
//      int n2 = b.get_Gear(); // error. 컴파일러가 이 함수를 생성하지만
                               // 이렇게 호출은 안됩니다.

        Console.WriteLine(b.Gear); // get 구문 호출.

        Type t = b.GetType();

        Console.WriteLine(t.Name);
//      t.Name = "AAA"; // error. 읽기 전용 프라퍼티
       
    }
}

// 1. 개발자 명령 프롬프트에서 "ildasm" 실행해 보세요

// 2. 현재 코드의 실행 파일을 ILDASM 에서 열어 보세요.
// =>    DAY1\bin\Debug\DAY1.exe

