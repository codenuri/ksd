using System;

// 핵심 5. value_type vs reference type

// C/C++ : 타입의 사용자가 객체의 메모리 위치를 결정.
// 일반적으로 크기가 작은 것은 stack 에
// 크기가 큰 객체는 힙에 많이 만들게 됩니다.
//Point pt;             // pt가 stack 에 놓이게 됩니다.
//Point* p = new Point; // 객체는 힙에 놓이고
                      // p라는 포인터가 가리킵니다.(p는 스택에 )

// java, C#, swift : 타입의 설계자가 객체의 메모리 위치를 결정
// struct : 객체 생성시 항상 stack 에 생성됨.
//          => value type

// class  : 객체 생성시 항상 힙에 생성됨. 가리키는 참조(포인터)가 stack 에 생성
//          => reference type

struct SPoint    
{
    public int x;
    public int y;
}
class CPoint    
{
    public int x;
    public int y;
}
class Program
{
    public static void Main()
    {
        // 아래 2줄의 메모리 그림을 항상 생각하세요

        // 핵심 1. 객체를 생성하는 방법은 완전히 동일합니다
        SPoint sp1 = new SPoint();
        CPoint cp1 = new CPoint();

        // 핵심 2. 하지만 메모리 위치는 완전히 다릅니다.

        // 핵심 3. 아래 코드의 결과를 메모리 모양을 완전히 이해 해야 합니다
        SPoint sp2 = sp1;   // 객체의 공유는 아닙니다.
        CPoint cp2 = cp1;   // 참조(주소)의 복사, 객체는 공유

        sp1.x = 10;
        sp2.x = 20;

        Console.WriteLine($"{sp1.x}, {sp2.x}"); // 10, 20

        cp1.x = 10;
        cp2.x = 20;

        Console.WriteLine($"{cp1.x}, {cp2.x}"); // 20, 20

        Int32 n2;

        int n3;
    }
}




// value type     : numeric primitive type, struct, enum
//                  (int, double 등도 결국 struct 입니다.)
//                  
// reference type : string, array, class, interface, delegate