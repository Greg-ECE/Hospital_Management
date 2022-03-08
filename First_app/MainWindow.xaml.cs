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

namespace First_app
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DoctorManagement_Click(object sender, RoutedEventArgs e)
        {
            Doctor_management doctor_Management = new Doctor_management();
            doctor_Management.Show();
        }

        private void PatientManagement_Click(object sender, RoutedEventArgs e)
        {
            Patient_Management patient_Management = new Patient_Management();
            patient_Management.Show();
        }

        private void AppointmentManagement_Click(object sender, RoutedEventArgs e)
        {
            Appointment_Management appointment_Management = new Appointment_Management();
            appointment_Management.Show();
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            ShowAll showAll = new ShowAll();
            showAll.Show();
        }
    }
}
