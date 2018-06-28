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

namespace Pr1wWpf
{
    /// <summary>
    /// Логика взаимодействия для DateWindow.xaml
    /// </summary>
    public partial class DateWindow : Window
    {
        bool dp1 = false, dp2 = false;

        public DateWindow()
        {
            InitializeComponent();
        }

        private void countDays()
        {
            if (dp1 == true && dp2 == true)
            {
                TimeSpan tspan = DaPi2.SelectedDate.Value.Date - DaPi1.SelectedDate.Value.Date;
                label2.Content = tspan.Days + " день (дней) разницы.";
            }
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            label.Content = Calen.SelectedDates[0];
            label1.Content = Calen.SelectedDates[Calen.SelectedDates.Count -1];
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dp1 = true;
            countDays();
        }

        private void DatePicker_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            dp2 = true;
            countDays();
        }
    }
}
