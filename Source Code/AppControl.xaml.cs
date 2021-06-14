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

namespace Hamburger_Menu
{
    /// <summary>
    /// Interaction logic for AppControl.xaml
    /// </summary>
    public partial class AppControl : UserControl
    {
        public AppControl()
        {
            InitializeComponent();
        }

        private void App_Minimize_Click(object sender, RoutedEventArgs e)
        {
            // Minimize the Window 
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void App_Maximize_Click(object sender, RoutedEventArgs e)
        {
            // Maximize / Normal Window State
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;

                // Top, Bottom Border Collapsed
                if (Application.Current.MainWindow is MainWindow MW)
                {
                    MW.Window_Edge.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;

                // Top, Bottom Border Visible
                if (Application.Current.MainWindow is MainWindow MW1)
                {
                    MW1.Window_Edge.Visibility = Visibility.Visible;
                }
            }
                
        }

        private void App_ShutDown_Click(object sender, RoutedEventArgs e)
        {
            // Close the Application
            Application.Current.MainWindow.Close();
        }
    }
}
