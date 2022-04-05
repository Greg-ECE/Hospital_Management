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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace First_app
{
    /// <summary>
    /// Logique d'interaction pour Doctor_management.xaml
    /// </summary>
    public partial class Doctor_management : Window
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        public Doctor_management()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

         var data = (from x in db.Patient
                    where x.PatientId == Convert.ToUInt32(code.Text)
                    select x).FirstOrDefault();

            name.Text = data.ToString();




            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Hospital; Integrated Security = True";
            //SqlConnection connection = new SqlConnection(connectionString);
            //string query = "INSERT INTO Doctors (DoctorId,DoctorName,DoctorTel,HiringDate,DoctorSpecialism) VALUES ('" + Int32.Parse(code.Text) + "','" + name.Text + "','" + Int32.Parse(tel.Text) + "','" + date.SelectedDate + "','" + speciality.Text +"') ";
            //Console.WriteLine(query);
            //SqlCommand command = new SqlCommand(query, connection);

            //try
            //{
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    Console.WriteLine("Records Inserted Successfully");
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message);
            //}
        }
    }
}
