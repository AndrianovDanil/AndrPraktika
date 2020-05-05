using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AndrPraktika000
{
    public partial class MP3_PLAYER : Window
    {
        public MP3_PLAYER()
        {
            InitializeComponent();
        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;
        private void Button_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            };
            bool? dialogOk = fileDialog.ShowDialog();
            if (dialogOk == true)
            {
                filename = fileDialog.FileName;
                FileName.Text = fileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));
            }
        }
        private void Button_Play(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
        private void Button_Pause(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}