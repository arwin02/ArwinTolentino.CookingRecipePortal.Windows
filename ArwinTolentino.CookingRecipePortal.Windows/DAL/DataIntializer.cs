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
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb1"),
                Title = "Caldereta",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Beef,TomatoSauce,Reno",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb2"),
                Title = "Nilagang Baka",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Beef,Repolyo,Patatas",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb3"),
                Title = "Bulalo",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Beef,Pechay,Repolyo",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "100php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb4"),
                Title = "Beef Brocoli",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Beef,Broboli,",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb5"),
                Title = "Beef Murcon",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Beef,TomatoSauce, Carrots",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "80php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb6"),
                Title = "Menudo",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,TomatoSauce,Reno",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb7"),
                Title = "Pork Sinigang",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Sampalok,Pechay",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb8"),
                Title = "Pork Binagoongan",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Bagoong,Talong",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14bb9"),
                Title = "Pork Higadilyo",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Reno,Mangtomas",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b10"),
                Title = "Dinuguan",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Dugo ng baboy,Suka,Sili",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b11"),
                Title = "Bopis",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Carrots,Reno",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b12"),
                Title = "Pork Adobo",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Toyo,Suka",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b13"),
                Title = "Pork Barbeque",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,MarinatedSauce,Toyo",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "25php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b14"),
                Title = "Pork Kare Kare",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Pechay,Talong,Bagoong",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b15"),
                Title = "Bicol Express",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Coconut Milk,sili",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b16"),
                Title = "Pork Giniling",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,TomatoSauce,Carrots,Patatas",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b17"),
                Title = "Letchon Kawali",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Mang Tomas",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "60php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b18"),
                Title = "Bagnet",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,Patis,Marinated Sauce",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b19"),
                Title = "Baby Back Ribs",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork,TomatoSauce,Reno,Sugar,Marinated Sauce",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b20"),
                Title = "Crispy Pata",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pork Pata,Suka,Toyo,Paminta,Bawang",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "120php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b21"),
                Title = "Mechado",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Chiken,TomatoSauce,Reno",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "50php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b22"),
                Title = "Chiken Gordon Blue",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Chiken,Ham,Cheeze,",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "80php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b23"),
                Title = "Chiken Pastel",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Chiken,Pineapple,Carrots,Nestlecream",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b24"),
                Title = "Chiken Inasal",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Chiken,Toyo,Marinated Sauce,Calamansi",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b25"),
                Title = "Fried Chiken",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Chiken,BreadedMix",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "50php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b26"),
                Title = "Inihaw na Bangus",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Bangus,Kamatis,Paminta,Sibuyas",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "80php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b27"),
                Title = "Paksiw na Bangus",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Bangus,Suka,Luya",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "50php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b28"),
                Title = "Adobo Pusit",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Pusit,Coconut Milk,Suka,Sibuyas",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b29"),
                Title = "Butter Shrimp",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Shirmp,Bawang,Butter",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "70php"
            });
            context.Recipes.Add(new Models.Recipe()
            {
                RecipeID = Guid.Parse("64ce7c42-fc1b-4c5b-842e-99254ca14b30"),
                Title = "SeaFood Kare Kare",
                Instruction = "1.2.3.4.5.",
                Ingredients = "Shrimp,Crab,Tahong,Corn,Butter,",
                UnitMeasure = "1spoon,3/4,2cup",
                Price = "110php"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("01ce7c42-fc1b-4c5b-842e-99254ca14b01"),
                FirstName = "Arwin",
                LastName = "Tolentino",
                Password = "wen02",
                EmailAddress = "rwin.tolentino02@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("02ce7c42-fc1b-4c5b-842e-99254ca14b02"),
                FirstName = "Larich",
                LastName = "Morales",
                Password = "larich10",
                EmailAddress = "larichmorales@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("03ce7c42-fc1b-4c5b-842e-99254ca14b03"),
                FirstName = "Wendhel",
                LastName = "Aton",
                Password = "aton11",
                EmailAddress = "wendhelaton@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("04ce7c42-fc1b-4c5b-842e-99254ca14b04"),
                FirstName = "Jane",
                LastName = "Tiar",
                Password = "ticar11",
                EmailAddress = "janeticar11@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("05ce7c42-fc1b-4c5b-842e-99254ca14b05"),
                FirstName = "Xyrille",
                LastName = "Mamalateo",
                Password = "xyanne13",
                EmailAddress = "xyrilleann.mamalateo@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("06ce7c42-fc1b-4c5b-842e-99254ca14b06"),
                FirstName = "Luisa",
                LastName = "Reyes",
                Password = "pangilinan09",
                EmailAddress = "luisareyes09@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("07ce7c42-fc1b-4c5b-842e-99254ca14b07"),
                FirstName = "Joy",
                LastName = "Flores",
                Password = "joyiie",
                EmailAddress = "joyflores@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("08ce7c42-fc1b-4c5b-842e-99254ca14b08"),
                FirstName = "Wesley",
                LastName = "Alipio",
                Password = "alipio22",
                EmailAddress = "wesleyalipio@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("09ce7c42-fc1b-4c5b-842e-99254ca14b09"),
                FirstName = "Reniel",
                LastName = "David",
                Password = "david89",
                EmailAddress = "renieldavid@gmail.com"
            });
            context.Users.Add(new Models.User()
            {
                UserID = Guid.Parse("10ce7c42-fc1b-4c5b-842e-99254ca14b10"),
                FirstName = "Arkian",
                LastName = "Salenga",
                Password = "arkian11",
                EmailAddress = "arkiansalenga11@gmail.com"
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Pork",
                UnitMeasure = "Kilo Gram",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Beef",
                UnitMeasure = "Kilo Gram",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Chiken",
                UnitMeasure = "Kilo Gram",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Salt",
                UnitMeasure = "spoon",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Water",
                UnitMeasure = "liter",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Soy Sauce",
                UnitMeasure = "liter",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Pepper",
                UnitMeasure = "spoon",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Egg",
                UnitMeasure = "piece",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Cabbage",
                UnitMeasure = "Kilo Gram",
            });
            context.Ingredients.Add(new Models.Ingredient()
            {
                Name = "Carrots",
                UnitMeasure = "Kilo Gram",
            });
            context.Tags.Add(new Models.Tag()
            {
                Title = "Appetizer",
                Price = "65php to 100php",
            });
            context.Tags.Add(new Models.Tag()
            {
                Title = "Dessert",
                Price = "35php to 60php",
            });
        }



    }
}
