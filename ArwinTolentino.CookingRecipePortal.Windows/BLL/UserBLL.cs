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
    public static class UserBLL
    {
        private static CookingRecipePortalDBContext db = new CookingRecipePortalDBContext();
        public static Paged<Models.User> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "First Name, Last Name", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<User> allUser = (IQueryable<User>)db.Users;
            Paged<Models.User> Users = new Paged<Models.User>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allUser = allUser.Where(e => e.FirstName.Contains(keyword));

            }
            var queryCount = allUser.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "FirstName" && sortOrder.ToLower() == "asc")
            {
                Users.Items = allUser.OrderBy(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "FirstName" && sortOrder.ToLower() == "desc")
            {
                Users.Items = allUser.OrderByDescending(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "LastName" && sortOrder.ToLower() == "asc")
            {
                Users.Items = allUser.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                Users.Items = allUser.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            Users.PageCount = pageCount;
            Users.QueryCount = queryCount;
            Users.PageIndex = pageIndex;
            Users.PageSize = pageSize;

            return Users;
        }
    }
}
