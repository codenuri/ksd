using System;
using System.Collections.ObjectModel;

// Collection : 여러개의 객체를 보관 하는 클래스 
//              (리스트, 트리, 해쉬 등 자료구조를 구현한 클래스)

// C#1.0 의 collection 은 "object" 를 저장합니다.
// 특징 : 다양한 타입의 객체를 하나의 collection 에 저장 가능
// => 타입 안정성이 부족하다.
// => 잘못된 객체를 넣어도 에러가 발생하지 않는다.
// => 꺼낼때 항상 캐스팅이 필요하다.
class Collection1
{
    public void Add(object item) { }
    public object Front() { return 0; }
}
// C# 2.0 
class Collection2<T>
{
    public void Add(T item) { }
    public T Front() { return default(T); }
}


class Program
{
    public static void Main()
    {
        Collection1 c1 = new Collection1();
        c1.Add(10);
        c1.Add(20); // 10, 20 을 보관해야 한다.
        //c1.Add("AAA");
        //c1.Add(3.4);

        //int n1 = c1.Front(); // error. 캐스팅 필요
        int n1 = (int)(c1.Front()); // ok

        Collection2<int> c2 = new Collection2<int>();
        c2.Add(10);
        c2.Add(20);

        // c2.Add("AA"); // error. 타입 안정성이 뛰어 나다!

        int n3 = c2.Front(); // 꺼낼때, 캐스팅이 필요 없다.
    }
}