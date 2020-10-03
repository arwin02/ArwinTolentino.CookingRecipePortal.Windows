using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArwinTolentino.CookingRecipePortal.Windows.Models
{
   public class Instruction
    {
       [Key] public string Description { get; set; }
        public string Date { get; set; }
        public string Contributer { get; set; }
    }
}
