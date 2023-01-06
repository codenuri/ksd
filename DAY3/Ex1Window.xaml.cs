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
    /// Ex1Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Window : Window
    {
        public Ex1Window()
        {
            // InitializeComponent 가 XAML을 load 합니다.
            // GUI 가 완전히 완성된후해야 하는 작업은
            // 반드시 InitializeComponent 아래 부분에서 하세요.

            InitializeComponent();

            // XAML 로 하는 모든 작업은 항상 C# 코드로도 할수 있습니다.
            this.Title = "WPF02";
        }
    }
}
