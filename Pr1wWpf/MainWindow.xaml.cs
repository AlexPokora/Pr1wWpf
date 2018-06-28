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
using System.Windows.Threading;

namespace Pr1wWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ImageWindow iw;
        DateWindow dw;
        VideoWindow vw;

        public MainWindow()
        {
            InitializeComponent();
            startTimeMethod();
        }

        private void createImageWindow()
        {
            iw = new ImageWindow();
        }

        private void createDateWindow()
        {
            dw = new DateWindow();
        }

        private void createVideoWindow()
        {
            vw = new VideoWindow();
        }


        private void startTimeMethod()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            TimeLabel.Content = DateTime.Now.ToLongTimeString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            createImageWindow();
            iw.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            createDateWindow();
            dw.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            createVideoWindow();
            vw.Show();
        }
    }
}
