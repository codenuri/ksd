using System;
using System.Reflection;

// 타입 정보 얻기
// C#의 타입
// Int32 가 정확한 타입 : "int" 는 별칭
// String  => "string"
// Object  => "object"
class Program
{
    public static void Main()
    {
        // 핵심 1. var 에 대해서..
        int n1 = 10;
        var n2 = 10; // 우변을 조사해서 컴파일러가 n2 의 타입을 결정해달라.

        int[] arr = { 1, 2, 3 };

        //int n3 = arr[0];
        var n3 = arr[0];

        // 핵심 2. 타입 조사하기
        // => C#의 모든 타입은 object로 부터 파생된다.
        // => object 안에는 GetType() 이라는 메소드가 있다.
        // => 모든 객체는 GetType() 메소드가 있다.
        Type t = n2.GetType();

        Console.WriteLine(t.Name);          // Int32
        Console.WriteLine(t.BaseType.Name); // 기반 클래스 타입. ValueType
        Console.WriteLine(t.BaseType.BaseType.Name);           // Object

        // Int32 => ValueType => Object
    }
}












