// step2. 윈도우 만들기
using System;
using System.Windows;

class App : Application
{
    [STAThread] // main 메소드는 싱글스레드를 사용하겠다는 의미(관례적인 코드)
    public static void Main()
    {
        App app = new App();

        // 방법 1.
        /*
        // 1. 윈도우 만들고
        Window win  = new Window();
        win.Show();

        // 2. app 객체에 등록
        app.MainWindow = win;

        app.Run();  // 프로그램 종료 하지 말고, event 처리 해달라는 것!
        */

        // 방법 2. 아래처럼 해도 됩니다.
        Window win = new Window();
        app.Run(win); 
    }
}
