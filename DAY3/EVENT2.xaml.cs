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
    /// EVENT2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EVENT2 : Window
    {
        public EVENT2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // 여러개 버튼을 한개의 함수 로 처리 할때
        // sender 가 event 를 발생시킨 버튼의 참조 입니다.
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            string s = btn.Content.ToString();

            Console.WriteLine(s);
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("StackPanel_Click");
        }
    }
}








