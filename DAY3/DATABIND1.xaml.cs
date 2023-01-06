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

namespace WPF06_BIND2
{
    /// <summary>
    /// DATABIND1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DATABIND1 : Window
    {
        public DATABIND1()
        {
            InitializeComponent();

            Person p = new Person();

            p.Name = "kim";
            p.Address = "pusan";

            stackpanel.DataContext = p; // 데이타 공급원은 "객체 p" 이다.
        }
    }
}
