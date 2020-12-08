using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeRepository
{
    public enum MealName
    {
        ClubSandwich = 1, 
        SoupOfTheDay, 
        ChefSalad, 
        HouseSalad,
        BagelSandwich, 
        CroissantSandwich
    }
    public class Menu
    {
        public MealName NameOfMeal { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Menu() { }
        public Menu(MealName meal, string mealDescription, string ingredients, double price)
        {
            NameOfMeal = meal;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;

        }

    }
}
