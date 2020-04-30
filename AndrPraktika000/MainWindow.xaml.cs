﻿using Microsoft.Win32;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Settings taskWindow = new Settings();
            taskWindow.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Группа 9ИСП-391к-17");
            sb.AppendLine("Васильев А.");
            sb.AppendLine("Андрианов Д.");
            sb.AppendLine("Наша ссылка на GitHub:");
            sb.AppendLine("https://github.com/AndrianovDanil/AndrVasVPraktika/tree/master2/AndrPraktika000");
            MessageBox.Show(sb.ToString());
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            WrapPanel wrapPanel = new WrapPanel();
            MessageBox.Show("Поле очищено");
        }
        private void newbutton(object sender, RoutedEventArgs e)
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
        private void newbutton1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
        }
        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
