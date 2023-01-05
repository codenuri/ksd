using System;


// 아래 모양의 delegate 가 필요하면 이미 표준에 있는 "Action" 사용하면 됩니다.
// delegate void HANDLER();

class Button
{
    //  public event HANDLER ClickAction = null;
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

        b.Click();
    }
}