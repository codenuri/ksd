using System;

// type parameter 제약
// int, string, template

class Generic3
{
    // 방법 1. int, string 버전을 각각 제공
    // => int, string 뿐 아니라 double 등 다양한 타입 버전도 만들어야 한다.
    /*
    public static int Max( int a, int b)
    {
        return a < b ? b : a;
    }

    public static string Max(string a, string b)
    {
        //return a < b ? b : a;
        return a.CompareTo(b) < 0 ? b : a;
    }
    */
    // 방법 2. 다양한 타입에 대해서 동작해야 하는 함수가 있다면 Generic 으로 작성
    // => 임의 타입 T가 CompareTo 메소드를 제공한다는 보장이 없습니다.
    // => 아래 처럼 작성하면 에러!
    /*
    public static T Max<T>(T a, T b)
    {
        // 이 안에서는 a, b 에 대해서 object 로 부터 파생된 멤버만 사용가능합니다.
        return a.CompareTo(b) < 0 ? b : a;
    }
    */

    // 해결책 1. a, b 를 IComparable 인터페이스 타입으로 캐스팅후 사용
    // => 단, 이경우 IComparable 를 구현하지 않았으면 null 
    /*
    public static T Max<T>(T a, T b)
    {
        IComparable ic1 = a as IComparable;
        IComparable ic2 = b as IComparable;

        if (ic1 == null) return a;

        return ic1.CompareTo(ic2) < 0 ? b : a;
    }
    */

    // 해결책 2. 조건을 만족하는 타입만 받겠다고 표기!!
    // => Generic constraint(제약)
    public static T Max<T>(T a, T b) where T : IComparable // , new()
    {
       // T t = new T();

        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
        Console.WriteLine(Max(10, 3)); // 10
        Console.WriteLine(Max("AA", "BB")); // "BB"
    }
}



// where T : class
// where T : struct
// where T : new()
// where T : interface이름
// where T : base class 이름