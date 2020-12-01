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

namespace ArwinTolentino.CookingRecipePortal.Windows.Tags
{
    /// <summary>
    /// Interaction logic for TagUpdate.xaml
    /// </summary>
    public partial class TagUpdate : Window
    {
        TgList myParentWindow = new TgList();
        private Tag thisTag;
        public TagUpdate(Tag tags,TgList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
            thisTag = tags;

            txtPrice.Text = thisTag.Price;
            txtTitle.Text = thisTag.Title;
                
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var op = TagBLL.Update(new Tag()
            {
                Title = txtTitle.Text,
                FeedBack = thisTag.FeedBack,
                Price = txtPrice.Text
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
