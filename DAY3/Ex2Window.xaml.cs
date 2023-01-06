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

namespace WPF02
{
    /// <summary>
    /// Ex2Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2Window : Window
    {
        public Ex2Window()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button8.Content = "7번 클릭"; 
        }
    }
}
