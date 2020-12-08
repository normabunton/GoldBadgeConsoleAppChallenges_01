using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeConsole
{
    class CafeProgramUI
    {
        public void Run()                              //Method that runs and starts the app
        {
            Menu();
        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                //Display options to the user
                Console.WriteLine("Select a menu option:\n" +
                                    "1. Create a new Menu Item\n" +
                                    "2. Delete a Menu Item\n" +
                                    "3. Diplay All Menu Items\n" +
                                    "4. Exit");
                //get the input
                string input = Console.ReadLine();
                //evaluate the input and act
                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        DeleteMenuItems();
                        break;
                    case "3":
                        DisplayAllMenuItems();
                        break;
                    case "4":
                        Console.WriteLine("Thank you, Goobye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.Thank you");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewMenuItem()                //create new MenuItem
        {
            
        }
        private void DeleteMenuItems()                  //Delete MenuItems
        {

        }
        private void DisplayAllMenuItems()              //View All MenuItems
        {

        }
    }
}
