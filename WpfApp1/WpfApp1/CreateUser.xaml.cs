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
using WpfApp1.BusniessLogic;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        LogicLayer ly = new LogicLayer();

        public CreateUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string fname = firstName.Text;
            string lname = lastName.Text;
            string emID = email.Text;
            string pwd = password.Text;
            string confirmpwd = connfirmPassword.Text;
            if(fname.Equals("") || lname.Equals("") || emID.Equals("") || pwd.Equals(""))
            {
                MessageBox.Show("Must Fill all field!");
                return;
            }
            if (pwd.Equals(confirmpwd))
            {
                ///////////////
                User user = new User(fname, lname, emID, pwd);
                ly.register(user);
                //////////////
                MessageBox.Show($"Submitted, {fname}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password and Confirm password does not match!");
                return;
            }

        }
    }
}
