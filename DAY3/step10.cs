using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xaml.Permissions;

// 예외 원인 : 아래 클래스에서 "public" 추가하세요
public class MainWindow : Window
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

        MainWindow win = null;

        using (FileStream fs = new FileStream("../../sample3.xaml", FileMode.Open))
        {
            win = (MainWindow)XamlReader.Load(fs);
        }

        app.Run(win);
    }
}
