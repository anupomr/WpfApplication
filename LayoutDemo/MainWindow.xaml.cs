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

namespace LayoutDemo
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

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;

            switch (button.Name)
            {
                case "btnCanvas":
                    frmMainArera.Content = new PgCAnvas();
                    break;
                case "btnDockPanel":
                    frmMainArera.Content = new PgDockPanel();
                    break;
                case "PgGrid":
                    frmMainArera.Content = new PgGrid();
                    break;
                case "PgStakePanel":
                    frmMainArera.Content = new PgStakePanel();
                    break;
                case "PgTextControl":
                    frmMainArera.Content = new PgTextControl();
                    break;
                case "btnUnknown":
                    frmMainArera.Content = new PgUniformGrid();
                    break;
                case "btnWrap":
                    frmMainArera.Content = new PgWrapPanel();
                    break;
            }


        }
    }
}
