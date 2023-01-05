using System;
using System.Text;

// mutable vs immutable

// mutable   : 객체의 속성을 변경할수 있는것
// immutable : 객체의 속성을 변경할수 없는것

class Program
{
    public static void Main()
    {
        // 1. int 타입은 mutable 합니다.
        int n1 = 10;
        n1 = 20;     // ok.


        // 2. string 타입은 immutable 합니다.
        string s1 = "hello";
//        s1[0] = 'A'; // error. string 은 값을 변경할수 없습니다.

        s1 = "AAA"; // ok.. ?? mutable 한거 아닌 가요 ?
                    // s2 = new string("AAA");  // 위 코드는 이 의미 입니다.
                    // 기존 객체의 상태 변경이 아닌
                    // 새로운 객체를 만들고, s1 참조가 새로운 객체를 
                    // 가리 키는 것.

        // 3. immutable 한 string 이 필요 하면 stringbuilder 사용하세요
        // string        : immutable
        // StringBuilder : mutable
        StringBuilder s2 = new StringBuilder("hello");

        s2[0] = 'A';

        Console.WriteLine(s2); // "Aello"

        // immutable 하면
        // 1. 읽기만 할수 있으므로 보다 안전합니다.
        // 2. 멀티스레드 환경에서 별도로 동기화코드를 작성할수 없습니다.



        // C/C++ : 모든 것은 mutable, const 사용해서 immutable 로 변경

        // C#/java : 타입에 따라 mutable, immutable

        // 함수형 언어 : 기본적으로 모든 타입은 immutable!!
        //              mutable 한 것이 필요 하면 별도의 키워드로 지정

    }
}






