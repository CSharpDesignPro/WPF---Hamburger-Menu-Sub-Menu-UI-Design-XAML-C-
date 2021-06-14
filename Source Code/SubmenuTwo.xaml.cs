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
using System.Windows.Media.Animation;

namespace Hamburger_Menu
{
    /// <summary>
    /// Interaction logic for SubmenuTwo.xaml
    /// </summary>
    public partial class SubmenuTwo : UserControl
    {
        public SubmenuTwo()
        {
            InitializeComponent();
        }

        private void Close_SubmenuTwo_Click(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuTwo Slide-Out Animation 
            Storyboard sb = FindResource("SubmenuTwo_Exit") as Storyboard;
            sb.Begin();

            // Disable Menu Container 
            SubmenuTwo_Container.IsEnabled = false;

            // Unselect Password Btn
            password_btn.IsSelected = false;

            // Unselect Notification Btn
            notification_btn.IsSelected = false;

            // Access the SubmenuOne UserControl Account Btn and Unselect it. 
            if (Application.Current.MainWindow is MainWindow MW)
            {
                MW.SubmenuOne_UC.account_btn.IsSelected = false;
            }
        }
    }
}
