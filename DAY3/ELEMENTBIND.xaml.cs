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

namespace WPF06_BIND
{
    /// <summary>
    /// ELEMENTBIND.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ELEMENTBIND : Window
    {
        public ELEMENTBIND()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label1.FontSize = slider1.Value;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // C# 코드로 2개 컨트롤을 연결(Binding) 하는 코드

            Binding b = new Binding();
            b.Source = slider2;
            b.Path = new PropertyPath("Value");
            b.Mode = BindingMode.TwoWay;

            label2.SetBinding(System.Windows.Controls.Label.FontSizeProperty, b);

            // 참고
            // "{AAAA arg}" : new AAA(arg)
            // "{AAAA pro_name1=arg1, pro_name2=arg2}" : AAA 객체를 만들고 property로 전달

            // 위 코드의 XAML 을 생각해 봅시다.
            // <Label  FontSize = "{Binding Mode=TwoWay, Path=Value, ElementName=slider2 } > 
         
        }
    }
}
