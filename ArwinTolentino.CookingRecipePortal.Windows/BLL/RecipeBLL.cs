﻿using System;
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
            Paged<Models.Recipe> Recipes = new Paged<Models.Recipe>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allRecipes = allRecipes.Where(e => e.Title.Contains(keyword));

            }
            var queryCount = allRecipes.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "asc")
            {
                Recipes.Items = allRecipes.OrderBy(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "desc")
            {
                Recipes.Items = allRecipes.OrderByDescending(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "price" && sortOrder.ToLower() == "asc")
            {
                Recipes.Items = allRecipes.OrderBy(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                Recipes.Items = allRecipes.OrderByDescending(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            Recipes.PageCount = pageCount;
            Recipes.QueryCount = queryCount;
            Recipes.PageIndex = pageIndex;
            Recipes.PageSize = pageSize;

            return Recipes;
        }
    }
}
