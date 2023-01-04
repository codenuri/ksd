using System;

// 3. param

class Program
{
    // 이 함수는 "정수 2개"를 전달해야 합니다.
    public static void f1(int a, int b )
    {
    }

    // 핵심 1. 동일 타입의 객체를 여러개(가변) 전달 받으려면
    // => 배열을 사용하면 됩니다.
    public static void f2(int[] arr)
    {
        foreach (var n in arr)
            Console.WriteLine(n);
    }

    // 핵심 2. param 를 사용하면 호출자가 배열이 아닌
    //        "10,20,30" 형태로 전달 가능합니다.
    public static void f3(params int[] arr)
    {
        foreach (var n in arr)
            Console.WriteLine(n);
    }

    public static void Main()
    {
        f2(new int[] { 10, 20, 30 });
        //f2(10, 20, 30);

        f3(new int[] { 10, 20, 30 });
        f3(10, 20, 30); // 인자가 params 라면 
                        // "10, 20, 30" => "new int[]{10,20,30}" 으로 컴파일러가 변경

//      f5(10, 20, 30);
    }

    // 주의 사항 - params 는 마지막 인자로만 사용가능.
//  public static void f4(int a, params int[] arr) { } // ok
//  public static void f5(params int[] arr, int n) { } // error
}