using System;

// 핵심 3. 키워드와 식별자

// int 는 이미 예약된 키워드 이므로 새로운 타입 만들때 사용안됩니다.
// 이때는 "@"를 붙이는 문법도 있습니다.
//class int
class @int
{
    public void show() { Console.WriteLine("int.show()"); }
}
class where { }

class Program
{
    public static void Main()
    {
        int n;

        @int n2 = new @int();
        n2.show();

    }

}

