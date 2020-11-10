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

namespace ArwinTolentino.CookingRecipePortal.Windows.Users
{
    /// <summary>
    /// Interaction logic for UrList.xaml
    /// </summary>
    public partial class UrList : Window
        {
        private string sortBy = "name";
        private string sortOrder = "asc";
        private string keyword = "";
        private int pageSize = 5;
        private int pageIndex = 1;
        private long pageCount = 1;

        public UrList()
        {
            InitializeComponent();

            cboSortBy.ItemsSource = new List<string>() { "UserID", "FirstName" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };
            showData();

        }
        private void showData()
        {
            var Users = UserBLL.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);
            dgUsers.ItemsSource = Users.Items;
            pageCount = Users.PageCount;
        }

        private void cboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sortBy = cboSortBy.SelectedValue.ToString();
            showData();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString().ToLower() == "ascending")
            {
                sortOrder = "asc";
            }
            else
            {
                sortOrder = "desc";
            }
            showData();

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };
            showData();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showData();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = (int)pageCount;
            showData();
        }





        private void txtFilters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtFilters.Text;
                showData();
            }
        }

        private void txtPageSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
            }
            InitializeComponent();
        }
    }
}
