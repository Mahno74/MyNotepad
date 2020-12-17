using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyNotepad {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e) {
            var response = MessageBox.Show("Do you really want to exit?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No) return;
             else Application.Current.Shutdown();
        }

        private void MenuItem_New_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("New");
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Open");
        }

        private void MenuItem_Save_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Save");
        }
    }
}
