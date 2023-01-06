using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF07_EVENT
{
    /// <summary>
    /// EVENT1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EVENT1 : Window
    {
        public EVENT1()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseLeftButtonDown(object sender,
                                                    MouseButtonEventArgs e)
        {
            Console.WriteLine("Rectangle_MouseLeftButtonDown");

            // 버블링 이벤트
            // => 발생한 이벤트를 부모 윈도우로 계속 전달하는 것
            // => "Chain Of Responsibility" 라는 디자인 패턴을 UI 에 적용한것

            // 버블링 되지 않게 하려면
            e.Handled = true;
        }



        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_MouseLeftButtonDown");
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Canvas_MouseLeftButtonDown");
        }

        // PreViewxxxx 이벤트는 부모 윈도우에서 먼저 이벤트를 받게 됩니다.
        // "터널링(Tunneling Event)" 라고 합니다.
        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_PreviewMouseLeftButtonDown");
        }

        private void Canvas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Canvas_PreviewMouseLeftButtonDown");
        }

        private void Rectangle_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Rectangle_PreviewMouseLeftButtonDown");
        }
    }
}
