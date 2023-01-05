using System;
using System.Windows;
using System.Windows.Media;

// step4-1. 이벤트 처리1
// => Windows 클래스에 있는 event 에 함수 등록
// => delegate 문법으로 만들어 진것

class App : Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();
        Window win = new Window();

        // 잘되신 분은 RBUTTONDOWN 누를 때도 로깅해 보세요.
        win.MouseLeftButtonDown += Win_MouseLeftButtonDown;
        win.MouseRightButtonDown += Win_MouseRightButtonDown;

        app.Run(win);
    }

    private static void Win_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        Console.WriteLine("RButtonDown");
    }

    private static void Win_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        Console.WriteLine("LButtonDown");
    }
}
