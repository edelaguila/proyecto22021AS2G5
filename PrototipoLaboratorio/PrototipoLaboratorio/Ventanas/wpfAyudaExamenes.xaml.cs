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
    /// Lógica de interacción para wpfAyudaExamenes.xaml
    /// </summary>
    public partial class wpfAyudaExamenes : Window
    {
        public wpfAyudaExamenes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://drive.google.com/file/d/1RgCZXM6VIXgfe_w0B84d3XXZzPPktvm8/view?usp=sharing") { UseShellExecute = true });
        }
    }
}
