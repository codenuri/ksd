using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xaml.Permissions;

// Step  9. 아래 코드의 문제점
// => sample2.xaml 에서 윈도우를 만들때  MainWindow 가 아닌 Window 를 사용해서 만들고 있다
// => 해결책은 다음 소스(sample3.xaml, step10.cs)

class MainWindow : Window
{
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        Console.WriteLine("LBUTTONDOWN");
    }


    public void InitializeComponent()
    {
 
    }


    public MainWindow()
    {
        InitializeComponent();
    }


}






class App : Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        //MainWindow win = new MainWindow();

        Window win = null;

        using (FileStream fs = new FileStream("../../sample2.xaml", FileMode.Open))
        {
            win = (Window)XamlReader.Load(fs);
        }

        app.Run(win);
    }
}
