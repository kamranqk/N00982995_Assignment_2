using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_2_w2022.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        ///  The Menu function takes 4 parameters
        ///  one item from each food menu category:
        ///  burger, drink, side and dessert.
        ///  Each food item is selected by
        ///  entering a fix digit choice(1-4).
        ///  Calories for each menu items are stores
        ///  in four differnt arrays respectively, 
        ///  according to the each menu item number.
        ///  Whenever the user select the menu items
        ///  and enters the numbers. The Menu function
        ///  pulls out calories for each item from the 
        ///  arrays' and add them together to get total
        ///  calories.
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <returns>total calories of selected items</returns>
        /// for example user selects 1,2,3,4 food items from menu:
        /// GET ../api/J1/Menu/1/2/3/4
        ///  output --> Your total calorie count is 691

        // GET : api/J1/Menu
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            List<int> burgerCalorieArray = new List<int> { 461, 431, 420, 0 };  //List array of burger Calories
                                                                                //{ Cheese burger, Fish Burger, Veggie Burger, no burger }
                                                                                //items respectively as burger Calorie list

            List<int> drinkCalorieArray = new List<int> { 130, 160, 118, 0 };   // list array of drink calories
                                                                                //{ soft drink, orange juice, milk, no drink}
                                                                                //items respectively as drink Calorie list

            List<int> sideCalorieArray = new List<int> { 100, 57, 70, 0 }; //List array of burger Calories
                                                                           //{ fries, baked potatoes, chef salad, no side order }
                                                                           //items respectively as side Calorie list

            List<int> dessertCalorieArray = new List<int> { 167, 266, 75, 0 };  //List array of dessert Calories
                                                                                //{ Apple pie, sundae, friut cup, no Dessert }
                                                                                //items respectively as dessert calorie list

            int burgerCalorie = burgerCalorieArray[burger - 1];    // [burger-1]= 0 index of burger Calorie array
            int drinkCalorie = drinkCalorieArray[drink - 1];       // [drink-1]= 0 index of drink Calorie array
            int sideCalorie = sideCalorieArray[side - 1];          // [side-1]= 0 index of sideCalorie array
            int dessertCalorie = dessertCalorieArray[dessert - 1]; // [dessert-1]= 0 index of dessert Calorie array

            int message = (burgerCalorie + drinkCalorie + sideCalorie + dessertCalorie);  //Add calories

            return "Your total calorie count is " + message; // return total calories
        }
    }
}
