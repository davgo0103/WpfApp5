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
    /// mathView.xaml 的互動邏輯
    /// </summary>
    public partial class mathView : Window
    {
        public mathView()
        {
            InitializeComponent();
        }

        private void Radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            int n1 = Convert.ToInt32(L1.Text);
            int n2 = Convert.ToInt32(L2.Text);
            if (add.IsChecked == true)
            {
                L3.Content = (n1 + n2);
            }
            else if (reduce.IsChecked == true)
            {
                L3.Content = (n1 - n2);
            }
            else if (multiplication.IsChecked == true)
            {
                L3.Content = (n1 * n2);
            }
            else if (division.IsChecked == true)
            {
                if(n2 == 0)
                {
                    MessageBox.Show("除數不能為0，重新輸入");
                }
                else
                {
                    L3.Content = (n1 / n2);
                }
                
            }
        }
    }
}
