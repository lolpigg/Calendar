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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarList
{
    /// <summary>
    /// Логика взаимодействия для DayItem.xaml
    /// </summary>
    public partial class DayItem : UserControl
    {
        public DayItem()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Element> elements = new List<Element>();
            DayElements dayElem = new DayElements(Convert.ToDateTime(Tag.ToString()), elements);
            (Application.Current.MainWindow as MainWindow).Calendar.Content = new SelectPage(dayElem);
        }
    }
}
