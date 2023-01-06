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
    /// DATABIND4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DATABIND4 : Window
    {
        public ObservableCollection<Person> list = new ObservableCollection<Person>();

        public DATABIND4()
        {
            InitializeComponent();

            list.Add(new Person { Name = "kim1", Address = "pusan1" });
            list.Add(new Person { Name = "kim2", Address = "pusan2" });
            list.Add(new Person { Name = "kim3", Address = "pusan3" });

            datagrid.ItemsSource = list;
        }
    }
}
