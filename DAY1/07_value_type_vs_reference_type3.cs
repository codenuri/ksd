using System;

// value_type 과 reference_type 조사

class Program
{
    public static void Main()
    {
        // 1. C# 에서 배열 만들기
        // array
        // C# : reference type 입니다.
        // swift : 신기하게도.. value type 입니다.
        int[] x = new int[] { 1, 2, 3, 4, 5 };  // 정확한 표기법

//      int[] x = { 1, 2, 3, 4, 5 }; // 이렇게도 가능


        // 2. 배열의 복사는 참조의 복사
        int[] y = x;  // 배열 자체는 공유, 참조만 복사

        y[0] = 20;
        Console.WriteLine($"{x[0]}"); // 20


        // 3. 배열 자체를 복사하려면 Clone() 메소드 사용
//      int[] z = x.Clone(); // error. object[] 타입으로 반환 되므로
        int[] z = (int[])x.Clone(); // ok

        x[1] = 30;

        Console.WriteLine($"{z[1]}"); // 2

        // 핵심 4. ValueType 인지 Reference Type 인지 조사하려면
        Type t = x.GetType();

        if ( t.IsValueType )
        {
            Console.WriteLine("ValueType");
        }
        else
            Console.WriteLine("Reference Type");
    }
}



