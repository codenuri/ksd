using System;

// event handling

delegate void HANDLER();

class Button
{
    public HANDLER ClickAction = null;

    public void Click()
    {
        // 버튼이 눌렸다는 사실을 외부에 알려야 한다.
        // (등록된 함수를 호출)
        if (ClickAction != null)
            ClickAction();
    }
}

class Program
{
    public static void Foo() { Console.WriteLine("Foo"); }

    public static void Main()
    {
        Button b = new Button();

        b.ClickAction += Foo; // 버튼을 누를때 호출할 함수 등록

        b.Click();
    }
}