using System;

// 식본문 메소드(expression-bodied method)

class Program
{
    public static int square1(int x) { return x * x; }

    // 함수 구현이 간단하고 반환 값 정도만 있다면
    // 아래 처럼 한줄로 만들어도 됩니다.
    // => expression-bodied method 라고 합니다.
    // => Rust 등의 최신 언어에서도 널리 사용되므로 꼭 알아 두세요.
    // => 권장 : statement(문장) vs expression(구문, 표현식) 의 차이점을 학습해 보세요
    public static int square2(int x) => x * x;

    // Rust 표기법 : return 과 ;가 없습니다.
    // public static int square2(int x) { x * x }; 

    public static void Main()
    {
        Console.WriteLine(square1(3));
    }

}