using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        

        public ImageWindow()
        {
            InitializeComponent();
        }


        //Открытие файла здеся
        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Выберите картинку";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imageBox.Source = new BitmapImage(new Uri(op.FileName));
                richTextBox.Document.Blocks.Clear();
                richTextBox.Document.Blocks.Add(new Paragraph(new Run( op.FileName )));
            }
        }

        //Сохранение тута 
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TextRange t = new TextRange(richTextBox.Document.ContentStart,
                                    richTextBox.Document.ContentEnd);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Текстовый документ (*.txt)|*.txt";
            if (sd.ShowDialog() == true)
            {
                FileStream file = new FileStream(sd.FileName, FileMode.Create);
                t.Save(file, System.Windows.DataFormats.Text);
                file.Close();
            }
            
            
        }
    }
}
