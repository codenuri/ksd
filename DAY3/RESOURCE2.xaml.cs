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

namespace WPF04_RESOURCE
{
    /// <summary>
    /// RESOURCE2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RESOURCE2 : Window
    {
        public RESOURCE2()
        {
            InitializeComponent();

            // this : Main Window 입니다.

            // Window 는 다양한 속성이 있습니다.
            this.Title = "AAA";

            // 핵심 : 윈도우 속성중에 Resource 라는 "Dictionary" 가 있습니다.
            // => 자주 사용되는 자원을 미리 생성해 놓고 사용할수 있습니다.
            // this.Resources["brush1"] = new SolidColorBrush(Colors.Red);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["brush2"] = new SolidColorBrush(Colors.Blue);
        }
    }
}
