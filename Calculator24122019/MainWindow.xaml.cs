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

namespace Calculator24122019
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

        private void radioButtonScientific1_Checked(object sender, RoutedEventArgs e)
        {
            
        }
        private void radioButtonStandart1_Click(object sender, RoutedEventArgs e)
        {
            gridStandart.Visibility = Visibility.Visible;
            gridScientific.Visibility = Visibility.Hidden;
            gridProgrammer.Visibility = Visibility.Hidden;
        }

        private void radioButtonScientific1_Click(object sender, RoutedEventArgs e)
        {
            gridStandart.Visibility = Visibility.Hidden;
            gridProgrammer.Visibility = Visibility.Hidden;
            gridScientific.Visibility = Visibility.Visible;

        }

        

        private void radioButtonProgrammer1_Click(object sender, RoutedEventArgs e)
        {
            gridProgrammer.Visibility = Visibility.Visible;
            gridStandart.Visibility = Visibility.Hidden;
            gridScientific.Visibility = Visibility.Hidden;
        }
    }
}
