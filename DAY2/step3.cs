using System;
using System.Windows;
using System.Windows.Media;

// step3. 윈도우 속성 변경

class App : Application
{
    [STAThread] 
    public static void Main()
    {
        App app = new App();
        Window win = new Window();

        win.Title= "Hello";
        win.Background = new SolidColorBrush(Colors.AliceBlue);
        win.Topmost = true;
        win.Width= 300;
        win.Height = 300;


        app.Run(win);
    }
}
