using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArwinTolentino.CookingRecipePortal.Windows.Models
{
    public class Recipe
    {
        public Guid? RecipeID { get; set; }
        public string Title { get; set; }
        public string Instruction { get; set; }
        public string Ingredients { get; set; }
        public string UnitMeasure { get; set; }
        public string Price { get; set; }
    }
}
