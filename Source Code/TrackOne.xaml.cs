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
    /// Interaction logic for TrackOne.xaml
    /// </summary>
    public partial class TrackOne : UserControl
    {
        public TrackOne()
        {
            InitializeComponent();
        }

        // Start TrackOne Open Indicator Animation
        public void Open_TackOne()
        {
            Storyboard sb = FindResource("TrackOne_Open") as Storyboard;
            sb.Begin();
        }

        // Start TrackOne Close Indicator Animation
        public void Close_TackOne()
        {
            Storyboard sb = FindResource("TrackOne_Close") as Storyboard;
            sb.Begin();
        }
    }
}
