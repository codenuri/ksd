using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step4-2 : 이벤트 처리 방법 2.
// => Window 로 부터 파생된 클래스 만들고
// => 약속된 가상함수 재정의

// 정리 : WPF 의 이벤트 처리 방법은 2개 입니다.
// 1. event(delegate) 에 함수 등록 - 일반적으로 널리 사용하는 방식
// 2. 가상함수 재정의 방식 


class MainWindow : Window
{
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        Console.WriteLine("OnLBUTTONDOWN");
    }

    // RButtonDown 도 해보세요.

    protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
    {
        Console.WriteLine("OnRBUTTONDOWN");
    }
}


class App : Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        app.Run(win);
    }
}
