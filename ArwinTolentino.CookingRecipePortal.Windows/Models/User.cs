using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArwinTolentino.CookingRecipePortal.Windows.Models
{
   public class User
    {
        public Guid? UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string EmailAddress { get; set; }
    }
}
