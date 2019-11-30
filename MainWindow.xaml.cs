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

namespace WpfControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void left_Checked(object sender, RoutedEventArgs e)
        {
            if (tabControl != null)
            {
                tabControl.TabStripPlacement = Dock.Left;
            }
        }

        private void top_Checked(object sender, RoutedEventArgs e)
        {
            tabControl.TabStripPlacement = Dock.Top;
        }

        private void right_Checked(object sender, RoutedEventArgs e)
        {
            tabControl.TabStripPlacement = Dock.Right;
        }

        private void bottom_Checked(object sender, RoutedEventArgs e)
        {
            tabControl.TabStripPlacement = Dock.Bottom;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (int.TryParse((string)buttonLabel.Content, out count))
            {
                count += 1;
                buttonLabel.Content = count.ToString();
            }
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (int.TryParse((string)toggleButtonLabel.Content, out count))
            {
                count += 1;
                toggleButtonLabel.Content = count.ToString();
            }
        }

        private void repeatButton_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (int.TryParse((string)repeatButtonLabel.Content, out count))
            {
                count += 1;
                repeatButtonLabel.Content = count.ToString();
            }
        }
    }
}
