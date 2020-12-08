using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeRepository
{
    //public enum MealName
    //{
    //    ClubSandwich = 1, 
    //    SoupOfTheDay, 
    //    ChefSalad, 
    //    HouseSalad,
    //    BagelSandwich, 
    //    CroissantSandwich
    //}
    public class Menu
    {                                 //POCO
        public string NameOfMeal { get; set; }
        public double MealNumber { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Menu() { }
        public Menu(string nameOfMeal, double mealNumber, string mealDescription, string ingredients, double price)
        {
            NameOfMeal = nameOfMeal;
            MealNumber = mealNumber;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;

        }

    }
}
