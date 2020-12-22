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
using ArwinTolentino.CookingRecipePortal.Windows.BLL;
using ArwinTolentino.CookingRecipePortal.Windows.Models;


namespace ArwinTolentino.CookingRecipePortal.Windows.Users
{
    /// <summary>
    /// Interaction logic for UserAdd.xaml
    /// </summary>()
    public partial class UserAdd : Window
    {
        UrList myParentWindow = new UrList();
        public UserAdd(UrList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errors.Add("First Name is required.");
            };

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errors.Add("Last Name is required.");
            };

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errors.Add("Password is required.");
            };

            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                errors.Add("Email is required.");
            };

            var message = string.Join(Environment.NewLine, errors);
            
            if (errors.Count > 0)

            {
                MessageBox.Show(message);
            }

            else { 

            var op = UserBLL.Add(new User()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text,
                EmailAddress = txtEmailAddress.Text,
                UserID = Guid.NewGuid()


            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);

            }
            else
            {
                MessageBox.Show("User is Succesfully added to table");

            }

            }
        }
    }
}
