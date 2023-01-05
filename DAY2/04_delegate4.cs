using System;


delegate void HANDLER();

class Button
{
//    public HANDLER ClickAction = null;

    // event 를 붙이면 +=, -= 외에는 사용할수 없게 됩니다. = 은 사용할수없음.
    // 원리
    // 1. add_ClickAction/remove_ClickAction 메소드를 컴파일러가 만들고
    // 2. += 로 등록할때 add_xxx,  -= 사용할때 remove_xxx 메소드를 호출하는 것
    // 3. =등의 다른 연산은 에러처리!

     public event HANDLER ClickAction = null;

    public void Click()
    {
        if (ClickAction != null)
            ClickAction();
    }
}

class Program
{
    public static void Foo() { Console.WriteLine("Foo"); }
    public static void Goo() { Console.WriteLine("Goo"); }

    public static void Main()
    {
        Button b = new Button();

        b.ClickAction += Foo; // b.add_ClickAction(Foo)
//      b.ClickAction += Goo;
//      b.ClickAction = Goo; // += 을 하려고 했는데, 실수로 = 를 했다.

        b.Click();
    }
}