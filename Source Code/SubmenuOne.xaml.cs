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
    /// Interaction logic for SubmenuOne.xaml
    /// </summary>
    public partial class SubmenuOne : UserControl
    {
        public SubmenuOne()
        {
            InitializeComponent();
        }

        private void Close_Submenu_Click(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-Out Animation 
            Storyboard sb = FindResource("SubmenuOne_Exit") as Storyboard;
            sb.Begin();

            // Disable Menu Panel
            Menu_Panel.IsEnabled = false;

            // Unselect Inbox Btn 
            inbox_btn.IsSelected = false;

            // Unselect Sent Btn
            sent_btn.IsSelected = false;

            // Unselect Account Btn 
            account_btn.IsSelected = false;

            // Access the SidePanel UserControl Mail Btn and Unselect it. 
            if (Application.Current.MainWindow is MainWindow MW)
            {
                MW.MainMenu_UC.SidePanel_UC.mail_sidepanel_listboxitem.IsSelected = false;
            }                      


        }

        private void account_btn_Selected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuTwo Slide-In Animation 
            Storyboard sb = FindResource("SubmenuTwo_Enter") as Storyboard;
            sb.Begin();

            // Access the SubmenuTwo UserControl Menu Container and Enable it. 
            if (Application.Current.MainWindow is MainWindow MW)
            {
                MW.SubmenuTwo_UC.SubmenuTwo_Container.IsEnabled = true;
            }

            // TrackTwo Enter Indicator
            if (Application.Current.MainWindow is MainWindow MW1)
            {
                MW1.Track_Two.Open_TackTwo();
            }

        }

        private void account_btn_Unselected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuTwo Slide-Out Animation 
            Storyboard sb = FindResource("SubmenuTwo_Exit") as Storyboard;
            sb.Begin();

            // TrackTwo Exit Indicator
            if (Application.Current.MainWindow is MainWindow MW1)
            {
                MW1.Track_Two.Close_TackTwo();
            }
        }
    }
}
