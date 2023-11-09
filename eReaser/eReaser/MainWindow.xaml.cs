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

namespace eReaser
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
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cbShowPass_Checked(object sender, RoutedEventArgs e)
        {
            tb_Password.Text = pb_Password.Password;
            pb_Password.Visibility = Visibility.Collapsed;
            tb_Password.Visibility = Visibility.Visible;
        }

        private void cbShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
            pb_Password.Password = tb_Password.Text;
            tb_Password.Visibility = Visibility.Collapsed;
            pb_Password.Visibility = Visibility.Visible;
        }

    }
}

