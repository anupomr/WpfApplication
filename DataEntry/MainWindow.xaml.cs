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

namespace DataEntry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxSemester.ItemsSource= new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };
            ListBoxCourses.ItemsSource= new List<string>() { "COMP100", "COMP123", "COMP212", "MATH185", "COMM171", "COMP122", "COMP213", "COMP120" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxSemester.SelectedIndex = 1;
            TextBoxName.Text = "Anupom Roy";
            ListBoxCourses.UnselectAll();
            RadioButtonDomestic.IsChecked = true;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = TextBoxName.Text;
            string status= (RadioButtonDomestic.IsChecked ?? true) ? " (DOM)" : " (INT)";
            string sem = ComboBoxSemester.SelectedValue.ToString();
            string sCourse = "";
            foreach (var course in ListBoxCourses.SelectedItems)
                sCourse+=course.ToString();
            string result = "Name: " + name + "\n Status:" + status+"\n Sem: "+sem+"\nCourse: "+ sCourse;
            MessageBox.Show(result, "User data", MessageBoxButton.OK);

        }
    }
}
