using System;

class Program
{
    public static void Main()
    {
        int n1 = 3;
        double d = n1;  // 정수(int) 를 실수(double) 타입의 변수에 넣기
                        // 데이타 손실 없다
                        // 허용

        int n2 = d;     // 실수 => 정수 변수에 넣기.
                        // 데이타 손실 가능성 있다.   
                        // error
        int n3 = (int)d; // ok. 명시적 캐스팅하면 가능

        // C/C++ : int<=>double 간 모두 암시적 변환 가능
        // C#    : int=>double 만 암시적 변환 가능
        // 함수형언어: 모두 암시적 변환 안됨. Rust 도 안됨.
    }
}