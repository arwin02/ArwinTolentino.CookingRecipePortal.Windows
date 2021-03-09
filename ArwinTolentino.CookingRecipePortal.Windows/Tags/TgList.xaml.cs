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
    /// Interaction logic for TgList.xaml
    /// </summary>
    public partial class TgList : Window
    {
            private string sortBy = "Title";
            private string sortOrder = "asc";
            private string keyword = "";
            private int pageSize = 1;
            private int pageIndex = 1;
            private long pageCount = 1;
            public TgList()
            {
                InitializeComponent();

                cboSortBy.ItemsSource = new List<string>() { "Title", "Price" };
                cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };
                showData();

            }
            public void showData()
            {
                var Tags = TagBLL.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);
                dgTag.ItemsSource = Tags.Items;
                pageCount = Tags.PageCount;
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

                  showData();
        }

        private void dgTag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            TagAdd addWindow = new Tags.TagAdd(this);
            addWindow.Show();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Tag tag = ((FrameworkElement)sender).DataContext as Tag;
            TagUpdate updateForm = new TagUpdate(tag, this);
            updateForm.Show();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Tag tags = ((FrameworkElement)sender).DataContext as Tag;

            if (MessageBox.Show("Are you sure you want to delete " + tags.Title + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = TagBLL.Delete(tags.Title);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Tag is successfully deleted from table");
                    showData();
                }
            };
        }

    }
}


