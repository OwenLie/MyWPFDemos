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

namespace ExtensionAttribute
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            users = new ObservableCollection<User>();
            users.Add(new User { Name = "Owen" });
            users.Add(new User { Name = "Lynn" });

            lbUser.ItemsSource = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbUser.SelectedItem != null)
                users.Remove(lbUser.SelectedItem as User);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (lbUser.SelectedItem != null)
                (lbUser.SelectedItem as User).Name = "Random Name";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User { Name = "New User" });
        }
    }
}
