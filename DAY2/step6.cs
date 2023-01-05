using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step  6. 자식 윈도우(컨트롤 만들기)

class MainWindow : Window
{
    public MainWindow()
    {
        Button btn = new Button();
        btn.Content = "확인";

        // MainWindow 에 Content 속성에 자식윈도우 부착하면 됩니다.
        this.Content = btn;  // this 는 없어도 됩니다.

        //this.Content = "Hello"; 

        btn.Click += Btn_Click;
    }

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("button click");
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
