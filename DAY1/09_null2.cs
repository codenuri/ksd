using System;

// Nullable 타입, ?, ??

class Program
{
    

    public static void Main()
    {
        // 핵심 1. value type 은 null 이 될수 없습니다.
        string s = null; // ok
        int n1 = null;   // error


        // 핵심 2. Nullable 을 사용하면 value 타입도 "값없음"을  null로 표현
        //         할수 있습니다.

        int n2 = 0; // 값 "0" 을 가짐
        Nullable<int> n3 = null; // n3는 유효한 값 없음.
                                 // int 값 한개 또는 값없음을 표현 가능
        int? n4 = null; // n3 와 완전히 동일
                        // syntax sugar..!! int? 는 컴파일 하면 Nullable<int>

        // 핵심 3. 왜 nullable 이 필요 한가요 ??
        // => 함수 반환값에서 사용하기 위해 만들었습니다.
        int  ret1 = Foo();
        int? ret2 = Goo();

        // 핵심 4. int 와 int? 사이의 관계
        // int? : int + bool 의 의미입니다. 집합관계 잘 생각하세요

        int? nv1 = 10;
        int  nn1 = 10;

        int? nv2 = nn1; // ok
        int  nn2 = nv1; // error

        int nn3 = nv1 ?? 0; // ok.  nv1이 null 이면 0사용
        int nn4 = (int)nv1; // ok.  nv1이 null 이면 예외 발생
    }






    // 아래 처럼 만들면 -1이 연산의 결과 인지 실패를 나타내는지 명확하지 않습니다.
    public static int Foo() { return -1; }

    public static int? Goo() { return null; } // 실패시 null 반환.


}


