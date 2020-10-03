using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArwinTolentino.CookingRecipePortal.Windows.DAL
{
   public class DataIntializer : System.Data.Entity.DropCreateDatabaseAlways<CookingRecipePortalDBContext>
    {
        protected override void Seed(CookingRecipePortalDBContext context)
        {
           context.Recipes.Add(new Models.Recipe()
           { RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bba"), 
             Title = "Caldereta",
             Instruction = "1.2.3.4.5.",
             Ingredients = "Beef,TomatoSauce",
             UnitMeasure = "1spoon,3/4,2cup",
             Price = "70php"
           });

        }
    }
}
