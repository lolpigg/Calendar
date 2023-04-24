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
    /// Логика взаимодействия для CalendarPage.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
        List<DayItem> DayItems = new List<DayItem>();
        public CalendarPage(List<bool> bools)
        {
            InitializeComponent();
            DatePic.Text = Convert.ToString(DateTime.Now);
            Clear();
        }

        private void NextMonth_Click(object sender, RoutedEventArgs e)
        {
            DatePic.Text = Convert.ToString(DatePic.DisplayDate.AddMonths(1));
        }

        private void PrevMonth_Click(object sender, RoutedEventArgs e)
        {
            DatePic.Text = Convert.ToString(DatePic.DisplayDate.AddMonths(-1));
        }
        private void Clear()
        {
            WrapPan.Children.Clear();
            for (int i = 0; i < DateTime.DaysInMonth(DatePic.DisplayDate.Year, DatePic.DisplayDate.Month); i++)
            {
                DayItem DayItem = new DayItem();
                DayItem.Day.Text = Convert.ToString(i + 1);
                string a = "";
                if (i+1<10)
                {
                    a += "0";
                }
                a += i + 1;
                DayItem.Tag = a + "." + DatePic.DisplayDate.Month + "." + DatePic.DisplayDate.Year;
                DayItems.Add(DayItem);
                WrapPan.Children.Add(DayItem);
            }
        }

        private void DatePic_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Clear();
        }
    }
}
