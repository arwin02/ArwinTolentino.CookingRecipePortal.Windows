using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArwinTolentino.CookingRecipePortal.Windows.Helpers;
using ArwinTolentino.CookingRecipePortal.Windows.DAL;
using ArwinTolentino.CookingRecipePortal.Windows.Models;

namespace ArwinTolentino.CookingRecipePortal.Windows.BLL
{
    public static class IngredientBLL
    {
        private static CookingRecipePortalDBContext db = new CookingRecipePortalDBContext();
        public static Paged<Models.Ingredient> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "name,", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Ingredient> allIngredient = (IQueryable<Ingredient>)db.Ingredients;
            Paged<Models.Ingredient> Ingredients = new Paged<Models.Ingredient>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allIngredient = allIngredient.Where(e => e.Name.Contains(keyword));

            }
            var queryCount = allIngredient.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "name" && sortOrder.ToLower() == "asc")
            {
                Ingredients.Items = allIngredient.OrderBy(e => e.Name).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "name" && sortOrder.ToLower() == "desc")
            {
                Ingredients.Items = allIngredient.OrderByDescending(e => e.Name).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "unitmeasure" && sortOrder.ToLower() == "asc")
            {
                Ingredients.Items = allIngredient.OrderBy(e => e.UnitMeasure).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                Ingredients.Items = allIngredient.OrderByDescending(e => e.UnitMeasure).Skip(skip).Take(pageSize).ToList();
            }
            Ingredients.PageCount = pageCount;
            Ingredients.QueryCount = queryCount;
            Ingredients.PageIndex = pageIndex;
            Ingredients.PageSize = pageSize;

            return Ingredients;
        }
    }
}
