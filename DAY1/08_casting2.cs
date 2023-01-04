using System;

// 핵심 5. 캐스팅
// is, as, 캐스트

class Animal { };

class Dog : Animal
{
    public void Cry() { Console.WriteLine("Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        // 1. 기반 클래스 타입의 참조로 파생 클래스를 가리킬수 있다.
        Animal a = new Dog();

        // 2. 실제 객체가 Dog 지만 참조가 Animal 타입이면
        //    a 로는 Dog 고유 멤버 접근은 안됩니다.
        //      a.Cry(); // error

        // 3. Dog 고유 멤버에 접근하려면 참조를 Dog 타입으로 캐스팅후 사용해야 합니다.
        Dog d1 = (Dog)a;    // 방법 1. a가 가리키는 객체가 Dog 가 아니면 예외 발생
                            // => a가 가리키는 객체가 Dog라는 확신이 있을때 사용
                            // => ValueType 도 가능

        Dog d2 = a as Dog;  // 방법 2. a가 가리키는 객체가 Dog 가 아니면 null 반환
                            // => 확신이 없거나, 아래 처럼 조사하고 싶을때 사용
                            // => valueType 은 안됨

        if ( d2 != null )
        {
            d2.Cry();
        }

        // 핵심 4. 캐스팅을 하는 것이 아니라..!!
        //          조사만 하려면  is 사용
        if (a is Dog) 
        { 
        }

        // is : 조사 
        // as : 캐스팅.
    }
}
                                                    


