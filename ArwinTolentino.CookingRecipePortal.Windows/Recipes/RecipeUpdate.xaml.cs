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

namespace ArwinTolentino.CookingRecipePortal.Windows.Recipes
{
    /// <summary>
    /// Interaction logic for RecipeUpdate.xaml
    /// </summary>
    public partial class RecipeUpdate : Window
    {
        List myParentWindow = new List();
        private Recipe thisRecipe;
        public RecipeUpdate(Recipe recipes, List parentWindow)
        {
            InitializeComponent();
            thisRecipe = recipes;
            myParentWindow = parentWindow;
           

            txtIngredients.Text = thisRecipe.Ingredients;
            txtInstruction.Text = thisRecipe.Instruction;
            txtTitle.Text = thisRecipe.Title;
            txtPrice.Text = thisRecipe.Price;
            txtUnitofMeasure.Text = thisRecipe.UnitMeasure;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var op = RecipeBLL.Update(new Recipe()
            {
                RecipeID = thisRecipe.RecipeID,
                Ingredients = txtIngredients.Text,
                UnitMeasure = txtUnitofMeasure.Text,
                Instruction = txtIngredients.Text,
                Title = txtTitle.Text,
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
