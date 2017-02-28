using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ListViewBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();

            employees = new ObservableCollection<Employee>();
            //employees.Add(new Employee
            //{
            //    UserId = 1001,
            //    Name = "Owen",
            //    Age = 23,
            //    Gender = true
            //});
            //employees.Add(new Employee
            //{
            //    UserId = 1002,
            //    Name = "Ricy",
            //    Age = 21,
            //    Gender = true
            //});
            //employees.Add(new Employee
            //{
            //    UserId = 1003,
            //    Name = "Vincent",
            //    Age = 22,
            //    Gender = false
            //});
            this.myList.ItemsSource = employees;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee
            {
                UserId = 1005,
                Name = "New Employee",
                Age = 25,
                Gender = false
            });
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (this.myList.SelectedItem != null)
                employees.Remove(this.myList.SelectedItem as Employee);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if(this.myList.SelectedItem != null)
            {
                (this.myList.SelectedItem as Employee).Name = "Alice";
            }
        }
    }
}
