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
    /// Interaction logic for SidePanel.xaml
    /// </summary>
    public partial class SidePanel : UserControl
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        private void mail_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-In Animation 
            Storyboard sb = FindResource("SubmenuOne_Enter") as Storyboard;
            sb.Begin();

            // Access the SubmenuOne UserControl Menu Panel and Enable it. 
            if (Application.Current.MainWindow is MainWindow MW)
            {
                MW.SubmenuOne_UC.Menu_Panel.IsEnabled = true;
            }

            // TrackOne Enter Indicator
            if (Application.Current.MainWindow is MainWindow MW1)
            {
                MW1.Track_One.Open_TackOne();
            }

        }

        private void mail_sidepanel_listboxitem_Unselected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-Out Animation 
            Storyboard sb = FindResource("SubmenuOne_Exit") as Storyboard;
            sb.Begin();

            // TrackOne Exit Indicator 
            if (Application.Current.MainWindow is MainWindow MW2)
            {
                MW2.Track_One.Close_TackOne();
            }
        }
    }
}
