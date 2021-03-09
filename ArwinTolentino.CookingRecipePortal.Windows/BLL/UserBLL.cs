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
            Paged<Models.User> users = new Paged<Models.User>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allUser = allUser.Where(e => e.FirstName.Contains(keyword));

            }
            var queryCount = allUser.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));
            if ((queryCount % pageSize) > 0)
            { pageCount += 1; }

            if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUser.OrderBy(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "desc")
            {
                users.Items = allUser.OrderByDescending(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "lastlame" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUser.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                users.Items = allUser.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            users.PageCount = pageCount;
            users.QueryCount = queryCount;
            users.PageIndex = pageIndex;
            users.PageSize = pageSize;

            return users;
        }
        public static Operation Add(User users)
        {
            try
            {
                db.Users.Add(users);
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
        public static Operation Update(User newRecord)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(e => e.UserID == newRecord.UserID);

                if (oldRecord != null)
                {
                    oldRecord.EmailAddress = newRecord.EmailAddress;
                    oldRecord.FirstName = newRecord.FirstName;
                    oldRecord.LastName = newRecord.LastName;
                    oldRecord.Password = newRecord.Password;
                    

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

        public static Operation Login(string emailAddress = "", string password = "")
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            if (string.IsNullOrEmpty(password))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            try
            {
                User user = db.Users.FirstOrDefault(e => e.EmailAddress.ToLower() == emailAddress.ToLower());

                if (user == null)
                {
                    return new Operation()
                    {
                        Code = "500",
                        Message = "Invalid Login"
                    };
                }

                if (password == user.Password)
                {
                    return new Operation()
                    {
                        Code = "200",
                        Message = "Successful Login",
                        ReferenceId = user.UserID
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
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

        public static Operation Delete(Guid? UserId)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(e => e.UserID == UserId);

                if (oldRecord != null)
                {
                    db.Users.Remove(oldRecord);

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
