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

namespace ArwinTolentino.CookingRecipePortal.Windows.Ingredients
{
    /// <summary>
    /// Interaction logic for IngUpdate.xaml
    /// </summary>
    public partial class IngUpdate : Window
    {
        IngList myParentWindow = new IngList();
        private Ingredient thisIngredient;
        public IngUpdate(Ingredient ingredients,IngList ParentWindow)
        {
            InitializeComponent();
            thisIngredient = ingredients;
            myParentWindow = ParentWindow;

            txtName.Text = thisIngredient.Name;
            txtUnitofMeasure.Text = thisIngredient.UnitMeasure;
           
        }
        
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var op = IngredientBLL.Update(new Ingredient()
            {
                Name = txtName.Text,
                UnitMeasure = txtUnitofMeasure.Text
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
