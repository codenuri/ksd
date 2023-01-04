using System;

// 생성자 호출 순서
class BM { public BM() { Console.WriteLine("BM()"); } }
class DM { public DM() { Console.WriteLine("DM()"); } }

class Base
{
    public int data = BaseFieldInit();
    public BM bm = new BM();
    protected Base() { Console.WriteLine("Base()"); }

    public static int BaseFieldInit() { Console.WriteLine("BaseFieldInit"); return 0; }
}

class Derived : Base
{
    public int data = DerivedFieldInit();
    public DM dm = new DM();

    public Derived() { Console.WriteLine("Derived()"); }

    
    public static int DerivedFieldInit() { Console.WriteLine("DerivedFieldInit"); return 0; }
}

class Program
{
    public static void Main()
    {
        // 아래 한 줄 실행시 결과를 잘 알아 두세요.
        Derived d = new Derived();

        // 1. 자신의 필드 초기화 구문 실행
        // 2. 기반 클래스 필드 초기화 구문 실행
        // 3. 기반 클래스 생성자
        // 4. 자신의 생성자 
    }
}