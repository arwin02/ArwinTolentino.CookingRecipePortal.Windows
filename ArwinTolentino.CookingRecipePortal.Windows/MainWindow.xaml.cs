﻿using ArwinTolentino.CookingRecipePortal.Windows.DAL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArwinTolentino.CookingRecipePortal.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CookingRecipePortalDBContext context = new CookingRecipePortalDBContext();
            var Recipe = context.Recipes.FirstOrDefault();


            MessageBox.Show(Recipe.UnitMeasure);

        }

        private void btnRecipes_Click(object sender, RoutedEventArgs e)
        {
            Recipes.List listWindows = new Recipes.List();
            listWindows.Show();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            Users.UrList listWindows = new Users.UrList();
            listWindows.Show();
        }

        private void btnIngredients_Click(object sender, RoutedEventArgs e)
        {
            Ingredients.IngList listwindows = new Ingredients.IngList();
            listwindows.Show();
        }
     

        private void btnTags_Click(object sender, RoutedEventArgs e)
        {
            Tags.TgList listwindows = new Tags.TgList();
            listwindows.Show();

        }
    }

}

