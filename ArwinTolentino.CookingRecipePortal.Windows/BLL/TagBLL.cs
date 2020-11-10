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
    public static class TagBLL
    {
        private static CookingRecipePortalDBContext db = new CookingRecipePortalDBContext();
        public static Paged<Models.Tag> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "Title, Price", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Tag> allTag = (IQueryable<Tag>)db.Tags;
            Paged<Models.Tag> Tags = new Paged<Models.Tag>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allTag = allTag.Where(e => e.Title.Contains(keyword));

            }
            var queryCount = allTag.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "Title" && sortOrder.ToLower() == "asc")
            {
                Tags.Items = allTag.OrderBy(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "Title" && sortOrder.ToLower() == "desc")
            {
                Tags.Items = allTag.OrderByDescending(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "Price" && sortOrder.ToLower() == "asc")
            {
                Tags.Items = allTag.OrderBy(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                Tags.Items = allTag.OrderByDescending(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            Tags.PageCount = pageCount;
            Tags.QueryCount = queryCount;
            Tags.PageIndex = pageIndex;
            Tags.PageSize = pageSize;

            return Tags;

        }
    }
}

