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

namespace DataBinding_SingleObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Medal medal { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            medal = new Medal() { Color = MedalColor.Gold, Athlete = "Hao Lac", IsRecord = true, Year = 2008, TheEvent = "100 meter hurdles" };
            DataContext = this;
        }
        private void btnChangeColor(object sender, RoutedEventArgs e)
        {
            medal.Color = MedalColor.Bronze;
        }
        private void btnChangeName(object sender, RoutedEventArgs e)
        {
            medal.Athlete = "Narendra";
        }
        private void btnShowObject(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(medal.ToString(), "Medal", MessageBoxButton.OK);
        }
    }
}
