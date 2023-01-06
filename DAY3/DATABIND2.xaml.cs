using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// DATABIND2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DATABIND2 : Window
    {
        //public List<Person> list = new List<Person>();

        public ObservableCollection<Person> list = new ObservableCollection<Person>();

        public DATABIND2()
        {
            InitializeComponent();

            list.Add(new Person { Name = "kim1", Address = "pusan1" } );
            list.Add(new Person { Name = "kim2", Address = "pusan2" });
            list.Add(new Person { Name = "kim3", Address = "pusan3" });

            // ListBox 와 같이 여러개를 보여주는 컨트롤에 Collection 을 직접 연결하기 - 가장 널리사용
            listbox.ItemsSource = list;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // IPropertyNotifyChanged 를 구현했으므로!!! 
            // 객체 속성 변경시 UI도 자동으로 변경
            list[0].Name = "lee1";
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // 핵심 : Collection 이 update 될때 UI도 update 될까 ?
            // => ObservableCollection 을 사용해야 합니다.
            list.Add(new Person { Name = "kim4", Address = "pusan4" });
        }
    }
}
