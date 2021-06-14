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
    /// Interaction logic for TrackTwo.xaml
    /// </summary>
    public partial class TrackTwo : UserControl
    {
        public TrackTwo()
        {
            InitializeComponent();
        }

        // Start TrackTwo Open Indicator Animation
        public void Open_TackTwo()
        {
            Storyboard sb = FindResource("TrackTwo_Open") as Storyboard;
            sb.Begin();
        }

        // Start TrackTwo Close Indicator Animation
        public void Close_TackTwo()
        {
            Storyboard sb = FindResource("TrackTwo_Close") as Storyboard;
            sb.Begin();
        }
    }
}
