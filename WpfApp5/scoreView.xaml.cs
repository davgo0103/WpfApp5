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
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// scoreView.xaml 的互動邏輯
    /// </summary>
    public partial class scoreView : Window
    {
        public scoreView()
        {
            scoreBlock = new TextBlock();
            Chinese = new Slider();
            Math = new Slider();
            English = new Slider();
            InitializeComponent();
            OWO();
        }
        void OWO()
        {
            double sum = (Chinese.Value * 0.5) + (Math.Value * 0.3) + (English.Value * 0.2);
            if (sum < 60)
            {
                scoreBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFCA7A7"));
            }
            else
            {
                scoreBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFA7FCB8"));
            }
            scoreBlock.Text = $"國文成績:{Chinese.Value}\n數學成績:{Math.Value}\n英文成績:{English.Value}\n總分:{sum}";

        }
        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            OWO();
            
        }
    }
}
