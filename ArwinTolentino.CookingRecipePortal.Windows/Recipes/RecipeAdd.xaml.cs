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

namespace ArwinTolentino.CookingRecipePortal.Windows.Recipes
{
    /// <summary>
    /// Interaction logic for RecipeAdd.xaml
    /// </summary>
    public partial class RecipeAdd : Window
    {
        List myParentWindow = new List();
        public RecipeAdd(List parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var op = RecipeBLL.Add(new Recipe()
            {
                Ingredients = txtIngredients.Text,
                Instruction = txtInstruction.Text,
                Price = txtPrice.Text,
                Title = txtTitle.Text,
                UnitMeasure = txtUnitofMeasure.Text,
                RecipeID = Guid.NewGuid()


            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);

            }
            else
            {
                MessageBox.Show("Ingrediets is Succesfully added to table");

            }
        }
    }
}
