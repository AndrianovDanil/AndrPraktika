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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;

namespace AndrPraktika000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_FON(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Background = brush;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Programm(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Группа 9ИСП-391к-17");
            sb.AppendLine("Васильев А.");
            sb.AppendLine("Андрианов Д.");
            sb.AppendLine("Наша ссылка на GitHub:");
            sb.AppendLine("https://github.com/AndrianovDanil/AndrVasVPraktika/tree/master2/AndrPraktika000");
            MessageBox.Show(sb.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (stackPanelAdd.Children.Count > 0)
            {
                stackPanelAdd.Children.RemoveAt(stackPanelAdd.Children.Count - 1);
            }
        }
        private void Button_TXT1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Andr.Items.Add(System.IO.Path.GetFileName(filename));
            }
        }
        private void Button_TXT(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
        }
        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_PNG(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            Image tb = new Image();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                tb.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
        private void Button_MP3(object sender, RoutedEventArgs e)
        {
            MP3_PLAYER taskWindow = new MP3_PLAYER();
            taskWindow.Owner = this;
            taskWindow.Show();
        }
    }

}
