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

namespace WpfDataBindingControl
{
    /// <summary>
    /// Interaction logic for WinCoding.xaml
    /// </summary>
    public partial class WinCoding : Window
    {
        public WinCoding()
        {
            InitializeComponent();
        }

        private void txtTarget_TextChanged(object sender, TextChangedEventArgs e)
        {
            sldSource.Value = Convert.ToDouble(txtTarget.Text);

        }

        private void sldSource_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtTarget.Text = sldSource.Value + "";
        }
    }
}
