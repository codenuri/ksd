using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step  5. WPF 프로그램의 기본 모양
// => 아래 처럼 2개의 클래스를 만들게 됩니다.
// => App : 프로그램의 전체적인 흐름을 책임지는 클래스 - 시작, 종료등..
// => MainWindow : 프로그램의 주윈도우를 담당

class MainWindow : Window
{

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
