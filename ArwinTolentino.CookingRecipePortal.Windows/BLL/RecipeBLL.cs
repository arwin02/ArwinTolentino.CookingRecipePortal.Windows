using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArwinTolentino.CookingRecipePortal.Windows.Helpers;
using ArwinTolentino.CookingRecipePortal.Windows.DAL;
using ArwinTolentino.CookingRecipePortal.Windows.Models;
using System.Runtime.CompilerServices;

namespace ArwinTolentino.CookingRecipePortal.Windows.BLL
{
    public static class RecipeBLL
    {
        private static CookingRecipePortalDBContext db = new CookingRecipePortalDBContext();
        public static Paged<Models.Recipe> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "title,", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Recipe> allRecipes = (IQueryable<Recipe>)db.Recipes;
            Paged<Models.Recipe> recipes = new Paged<Models.Recipe>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allRecipes = allRecipes.Where(e => e.Title.Contains(keyword));

            }
            var queryCount = allRecipes.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));
            if ((queryCount % pageSize) > 0)
            { pageCount += 1; }

            if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "asc")
            {
                recipes.Items = allRecipes.OrderBy(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "desc")
            {
                recipes.Items = allRecipes.OrderByDescending(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "price" && sortOrder.ToLower() == "asc")
            {
                recipes.Items = allRecipes.OrderBy(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                recipes.Items = allRecipes.OrderByDescending(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            recipes.PageCount = pageCount;
            recipes.QueryCount = queryCount;
            recipes.PageIndex = pageIndex;
            recipes.PageSize = pageSize;

            return recipes;
        }
        public static Operation Add(Recipe recipe)
        {
            try
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();

                return new Operation()

                {
                    Code = "200",
                    Message = "ok",
                    ReferenceId =  recipe.RecipeID
                };

            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

        public static Operation Update(Recipe newRecord)
        {
            try
            {
                Recipe oldRecord = db.Recipes.FirstOrDefault(e => e.RecipeID == newRecord.RecipeID);

                if (oldRecord != null)
                {
                    oldRecord.Ingredients = newRecord.Ingredients;
                    oldRecord.UnitMeasure = newRecord.UnitMeasure;
                    oldRecord.Price = newRecord.Price;
                    oldRecord.Instruction = newRecord.UnitMeasure;
                    oldRecord.Title = newRecord.Title;

                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };




                }
                return new Operation()
                {
                    Code = "500",
                    Message = "Not Found"
                };

            }
            catch (Exception e)
            {

                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }
        public static Operation Delete(Guid? recipeId)
        {
            try
            {
                Recipe oldRecord = db.Recipes.FirstOrDefault(e => e.RecipeID == recipeId);

                if (oldRecord != null)
                {
                    db.Recipes.Remove(oldRecord);

                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

    }
}

