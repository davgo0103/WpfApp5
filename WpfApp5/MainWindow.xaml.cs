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

namespace WpfApp5
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void scoreButton_Click(object sender, RoutedEventArgs e)
        {
            scoreView scoreview= new scoreView();
            scoreview.ShowDialog();
        }

        private void mathButton_Click(object sender, RoutedEventArgs e)
        {
            mathView mathview = new mathView();
            mathview.ShowDialog();
        }
    }
}
