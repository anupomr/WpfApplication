﻿using System;
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

namespace WpfDataBindingControl
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

        private void UniformGrid_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            switch (button.Name)
            {
                case "btnCoding":
                    new WinCoding().ShowDialog();
                    break;
                case "btnTwoWay":
                    new WinTwoWay().ShowDialog();
                    break;
                case "btnOneWayToTarget":
                    new WinOneWayToTarget().ShowDialog();
                    break;
                case "btnOneWayToSource":
                    new WinOneWayToSource().ShowDialog();
                    break;
                case "btnOneTime":
                    new WinOneTimeToTarget().ShowDialog();
                    break;

            }
                 

        }
    }
}
