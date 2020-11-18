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

namespace ArwinTolentino.CookingRecipePortal.Windows.Tags
{
    /// <summary>
    /// Interaction logic for TagAdd.xaml
    /// </summary>
    public partial class TagAdd : Window
    {
        TgList myParentWindow = new TgList();
        public TagAdd(TgList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }
        public TagAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var op = TagBLL.Add(new Tag()
            {
                Title = txtTitle.Text,
                Price = txtPrice.Text,
               
            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);

            }
            else
            {
                MessageBox.Show("Tag is Succesfully added to table");

            }
        }
    }
}
