using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step  7. Layout 만들기

class MainWindow : Window
{
    public MainWindow()
    {
        // 1. Lauout 객체를 먼저 생성
        //    Grid : row, col 로 자식을 배치하는 layout
        Grid grid = new Grid();

        // 2. Grid layout 인 경우, row, col 을 지정
        //grid.SetRow(2); // 일반적인 라이브러리는 이렇게 지정하는 경우가 많지만
        // WPF 는 이렇게하지 않습니다.

        // 아래 코드가 Grid 를 2*2 로 만드는 코드
        // grid.RowDefinitions : Collection 입니다.
        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition());

        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());

        grid.ShowGridLines= true;

        // 3. grid layout 을 Window 의 content 속성에 연결
        this.Content = grid;

        // 4. Layout 에 부착할 자식 컨트롤 생성
        Button btn1 = new Button();
        btn1.Content = "button1";   // Content 가 항상 중요합니다.
                                    // 버튼의 문자열이 됩니다.

        // 5. button 이 Grid에 어느 위치 에 놓일지 지정. 이 코드를 잘 알아두세요
        // grid.AddChild(btn1, 0, 0); // WPF 스타일 아닙니다.
        Grid.SetRow(btn1, 0);
        Grid.SetColumn(btn1, 0);

        // 6. grid 가 가진 내부 collection에 자식 컨트롤 부착
        grid.Children.Add(btn1);

        // 다하신 분은 버튼 한개 더 만들어서 1, 1 에 부착해 보세요.

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
