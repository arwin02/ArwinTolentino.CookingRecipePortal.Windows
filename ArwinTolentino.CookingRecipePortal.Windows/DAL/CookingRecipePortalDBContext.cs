using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArwinTolentino.CookingRecipePortal.Windows.Models;

namespace ArwinTolentino.CookingRecipePortal.Windows.DAL
{
   public class CookingRecipePortalDBContext : DbContext
    {
        public CookingRecipePortalDBContext() : base("myConnectionstring")
        {
          //Database.SetInitializer(new ArwinTolentino.CookingRecipePortal.Windows.DAL.DataIntializer());
        }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Recipe> Recipes { get; set; }
        public DbSet<Models.Ingredient> Ingredients { get; set; }
        public DbSet<Models.Tag> Tags { get; set; }

    }

}
