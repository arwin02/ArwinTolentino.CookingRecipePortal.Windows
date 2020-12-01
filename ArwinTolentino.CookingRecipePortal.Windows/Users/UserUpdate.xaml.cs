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
using ArwinTolentino.CookingRecipePortal.Windows.Models;
using ArwinTolentino.CookingRecipePortal.Windows.BLL;

namespace ArwinTolentino.CookingRecipePortal.Windows.Users
{
    /// <summary>
    /// Interaction logic for UserUpdate.xaml
    /// </summary>
    public partial class UserUpdate : Window
    {
        UrList myParentWindow = new UrList();
        private User thisUser;

        public UserUpdate(User users,UrList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
            thisUser = users;

            txtEmailAddress.Text = thisUser.EmailAddress;
            txtFirstName.Text = thisUser.FirstName;
            txtLastName.Text = thisUser.LastName;
            txtPassword.Text = thisUser.Password;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var op = UserBLL.Update(new User()
            {
      UserID = thisUser.UserID,
      EmailAddress = txtEmailAddress.Text,
      FirstName = txtFirstName.Text,
      LastName = txtLastName.Text,
      Password = txtPassword.Text
            });
            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);

            }
            else
            {
                MessageBox.Show("Succesfully Update");

            }
            myParentWindow.showData();
            this.Close();

        }
    }
}
