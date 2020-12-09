using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeRepository
{
    public class Menu
    {                                 
        public double MealNumber { get; set; }
        public string NameOfMeal { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public Menu() { }                                                                                           //empty constructor
        public Menu(double mealNumber, string nameOfMeal, string mealDescription, string ingredients, double price) //constructors with parameters
        {
            MealNumber = mealNumber;
            NameOfMeal = nameOfMeal;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
