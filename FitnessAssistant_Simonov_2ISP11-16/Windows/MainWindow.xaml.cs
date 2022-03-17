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
using FitnessAssistant_Simonov_2ISP11_16.Windows;

namespace FitnessAssistant_Simonov_2ISP11_16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ResultWindow resultWindow = new ResultWindow();
            resultWindow.ShowDialog();
            this.Close();
        }

        private void tbRegistr_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
            this.Close();
        }

    }
}
