using System;

// null1.cs

// ?? : 널 접합 연산자(null-coalescing operator)
// ?  : 널 조건부 연산자(null-conditional operator, 'Elvis' operator)

class Car
{
    public void Go() { Console.WriteLine("Car Go"); }
}

class Program
{
    public static Car CreateCar(int speed)
    {
        if (speed < 200)
            return new Car();

        return null;
    }

    public static void Main()
    {
        // 핵심 1. CreateCar() 메소드는 인자에 따라 실패 할수도 있다.(null반환)
        //       Car c = CreateCar(100);
        Car c = CreateCar(300);

 //     c.Go(); // c가 null 이면 예외 발생
        

        if ( c != null ) { c.Go(); }

        // 핵심 2. ? 연산자
        c?.Go(); // 위 if 문과 완전히 동일합니다.


        // 핵심 3. ?? 연산자
        string name = null;
        string s1 = name; // s1 도 결국 null
        string s2 = name ?? "이름없음";
                            // name != null 이면 name 사용
                            // name == null 이면 "이름없음" 사용

        Console.WriteLine($"s1 = {s1}, s2 = {s2}");
    }
}

