using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xaml.Permissions;

// Step  8. UI 를 만들때 XAML 사용하기

class MainWindow : Window
{

    public void InitializeComponent()
    {
        Grid grid = null;

        // XAML 파일을 Load 해서 UI 를 생성합니다.
        using (FileStream fs = new FileStream("../../sample1.xaml", FileMode.Open))
        {
            grid = (Grid)XamlReader.Load(fs);
        }

        // XAML 에서 만든 grid를 윈도우에 부착합니다.
        this.Content = grid;
    }






    public MainWindow()
    {
        InitializeComponent();
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("button1 click");
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
