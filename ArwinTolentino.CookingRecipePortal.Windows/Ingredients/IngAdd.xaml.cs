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
    /// Interaction logic for IngAdd.xaml
    /// </summary>
    public partial class IngAdd : Window
    {
        IngList myParentWindow = new IngList();
        public IngAdd(IngList ParentWindow)
        {
            InitializeComponent();
            myParentWindow = ParentWindow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var op = IngredientBLL.Add(new Ingredient()
            {
                Name = txtName.Text,
                UnitMeasure = txtUnitofMeasure.Text,
            });

            if (op.Code !="200")
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
