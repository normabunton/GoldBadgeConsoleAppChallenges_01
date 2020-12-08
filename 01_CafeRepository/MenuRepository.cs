using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeRepository
{                                 /// CRUD METHODS 
    public class MenuRepository
    {
        private List<Menu> _menuItems = new List<Menu>();
        //create new menu items
        public void AddItemToMenu(Menu menuItem)
        {
            _menuItems.Add(menuItem);
        }
        //read list of all items on the cafe menu
        public List<Menu> GetMenuItems()
        {
            return _menuItems;
        }
        //delete menu items
        public bool RemoveItemFromMenu(double mealNumber)
        {
            Menu menuItem = GetMenuItemByMealNumber(mealNumber);
            if(menuItem == null)
            {
                return false;
            }
            int initialCount = _menuItems.Count;
            _menuItems.Remove(menuItem);
            if(initialCount > _menuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //HelperMethod
        private Menu GetMenuItemByMealNumber(double mealNumber)
        {
            foreach (Menu menuItems in _menuItems)
            {
                if (menuItems.MealNumber == mealNumber)
                {
                    return menuItems;
                }
            }
            return null;


        }


    }       
    
}


