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
    /// EVENT3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EVENT3 : Window
    {
        public EVENT3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 프로그램을 종료 하려면 Application 클래스가 제공하는
            // Shutdown 메소드를 호출하면 됩니다.
            // this.Shutdown(); // ?????

            // App 객체를 참조를 얻는 방법!!! 너무 중요합니다. 꼭 기억하세요
            Application app = Application.Current;

            app.Shutdown();
        }
    }
}
