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
    // 프로그램에서 사용할 브러시 및 다양한 객체를 static 멤버로 제공하는 클래스
    public class MyConstant
    {
        public static Brush brush1 = new SolidColorBrush(Colors.Yellow);
        public static Brush brush2 = new SolidColorBrush(Colors.Red);

        public static double fontsize1 = 18;
    }



    public partial class RESOURCE1 : Window
    {
        public RESOURCE1()
        {
            InitializeComponent();
        }
    }
}
