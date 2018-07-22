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

namespace EzATC_Assistant
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Bisher wird hier nur das zweite Fenster geöffnet. Später wird hier die Verbindung
            //zu den IVAO-Servern gemacht und die Logik für die Session bereitgestellt
            SessionWindow sw = new SessionWindow();
            sw.Show();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Endet das Programm.
            System.Windows.Application.Current.Shutdown();
        }
    }
}
