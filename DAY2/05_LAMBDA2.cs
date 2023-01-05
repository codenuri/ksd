using System;

class Button
{
    public event Action ClickAction = null;

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

        b.ClickAction += Foo;

        // 람다 표현식으로 버튼의 이벤트 핸들러 등록
        // => 버튼 누를때 하는일이 간단한경우, 이렇게 처리하는 경우도 많음
        b.ClickAction += () => Console.WriteLine("버튼 눌림");

        b.Click();
    }
}