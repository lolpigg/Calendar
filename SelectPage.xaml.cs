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
    /// Логика взаимодействия для SelectPage.xaml
    /// </summary>
    public partial class SelectPage : Page
    {
        DayElements dayElements;
        Element sport = new Element("Спорт", "https://static.thenounproject.com/png/1046840-200.png");
        Element walking = new Element("Прогулка", "https://icons.veryicon.com/png/o/miscellaneous/indata/walking-1.png");
        Element study = new Element("Учёба", "https://cdn-icons-png.flaticon.com/512/566/566944.png");
        Element play = new Element("Игры", "https://cdn-icons-png.flaticon.com/512/13/13973.png");
        DayContent sportContent = new DayContent();
        DayContent walkingContent = new DayContent();
        DayContent studyContent = new DayContent();
        DayContent playContent = new DayContent();
        public SelectPage(DayElements dayElements)
        {
            InitializeComponent();
            this.dayElements = dayElements;
            Uri uri = new Uri(sport.img, UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            sportContent.Img.Source = imgSource;
            Uri uri1 = new Uri(walking.img, UriKind.Absolute);
            ImageSource imgSource1 = new BitmapImage(uri1);
            walkingContent.Img.Source = imgSource1;
            Uri uri2 = new Uri(study.img, UriKind.Absolute);
            ImageSource imgSource2 = new BitmapImage(uri2);
            studyContent.Img.Source = imgSource2;
            Uri uri3 = new Uri(play.img, UriKind.Absolute);
            ImageSource imgSource3 = new BitmapImage(uri3);
            playContent.Img.Source = imgSource3;
            SelectList.Items.Add(sportContent);
            SelectList.Items.Add(walkingContent);
            SelectList.Items.Add(studyContent);
            SelectList.Items.Add(playContent);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            List<bool> bools = new List<bool> { Convert.ToBoolean(sportContent.Select.IsChecked), Convert.ToBoolean(walkingContent.Select.IsChecked), Convert.ToBoolean(studyContent.Select.IsChecked), Convert.ToBoolean(playContent.Select.IsChecked) };
            (Application.Current.MainWindow as MainWindow).Calendar.Content = new CalendarPage(bools);
        }

        private void NoSave_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).Calendar.Content = new CalendarPage(new List<bool>());
        }
    }
}
