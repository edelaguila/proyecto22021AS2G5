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
    /// Lógica de interacción para wpfAyudaPersonal.xaml
    /// </summary>
    public partial class wpfAyudaPersonal : Window
    {
        public wpfAyudaPersonal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.example.com") { UseShellExecute = true });
        }
    }
}
