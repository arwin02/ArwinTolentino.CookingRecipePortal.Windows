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
            Paged<Models.Tag> tags = new Paged<Models.Tag>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allTag = allTag.Where(e => e.Title.Contains(keyword));

            }
            var queryCount = allTag.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "Title" && sortOrder.ToLower() == "asc")
            {
                tags.Items = allTag.OrderBy(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "Title" && sortOrder.ToLower() == "desc")
            {
                tags.Items = allTag.OrderByDescending(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "Price" && sortOrder.ToLower() == "asc")
            {
                tags.Items = allTag.OrderBy(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                tags.Items = allTag.OrderByDescending(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            tags.PageCount = pageCount;
            tags.QueryCount = queryCount;
            tags.PageIndex = pageIndex;
            tags.PageSize = pageSize;

            return tags;

        }
        public static Operation Add(Tag tags)
        {
            try
            {
                db.Tags.Add(tags);
                db.SaveChanges();

                return new Operation()

                {
                    Code = "200",
                    Message = "ok",

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

