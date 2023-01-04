using System;

// 주제 : property
// ildasm 으로 확인
// 1. 사용시에는 필드처럼 보이지만 구현시에는 메서드 처럼 만드는 코드.

class Bike
{
    //  public int gear = 0;

    private int gear = 0;

    public int GetGear() { return gear; }

    public void SetGear(int g) 
    {
        // 인자값의 유효성을 확인후, 유효한 경우만 객체의 상태를 변경한다.
        if ( g > 0 && g < 20 )
            gear = g;

        // 이제 객체의 기어 상태는 1 ~ 19 사이의 유효한 값만 가질수 있다
    }
}
class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        //      b.gear = -10;   // 사용자의 실수로 객체가
                                // 잘못된 상태를 가지게 되었다.
                                // private 에 놓으면 이 코드는 에러

        b.SetGear(-10);

        Console.WriteLine(b.GetGear());

    }
}

