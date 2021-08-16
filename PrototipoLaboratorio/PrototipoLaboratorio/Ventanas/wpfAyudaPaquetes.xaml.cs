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
using System.Diagnostics;

namespace PrototipoLaboratorio.Ventanas
{
    /// <summary>
    /// Lógica de interacción para wpfAyudaPaquetes.xaml
    /// </summary>
    public partial class wpfAyudaPaquetes : Window
    {
        public wpfAyudaPaquetes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://drive.google.com/file/d/14d4kWpmf4mmp3Iw65dULjOpUpvYiVnvX/view?usp=sharing") { UseShellExecute = true });
        }
    }
}
