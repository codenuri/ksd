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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF02
{
    // MyColor 의 객체를 생성해서 "약속된 함수인 ProvideValue" 를 호출하면
    // "노란색 브러시" 를 얻게 됩니다.
    public class MyColor : MarkupExtension
    {
        private string key = null;

        public MyColor(string s) { key = s; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            switch(key)
            {
                case "TitleColor": return new SolidColorBrush(Colors.Red);
                case "HeaderColor": return new SolidColorBrush(Colors.Blue);
            }
            return new SolidColorBrush(Colors.Yellow);
        }
    }





    /// <summary>
    /// Ex3Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3Window : Window
    {
        public Ex3Window()
        {
            InitializeComponent();
        }
    }
}
