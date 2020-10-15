using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_n01454046.Controllers
{
    public class Assignment2Controller : ApiController
    {

        /// <summary>
        /// This method returns a string that has calculated to total number of calories of the meal selected
        /// </summary>
        /// <example>GET api/Assignment2/J1/Menu/4/4/4/4 </example>
        /// <param name="burger"> an INT value from 1-4 indicating burger selection </param>
        /// <param name="drink"> an INT value from 1-4 indicating drink selection </param>
        /// <param name="side"> an INT value from 1-4 indicating side selection </param>
        /// <param name="dessert"> an INT value from 1-4 indicating dessert selection </param>
        /// <returns> Your total calorie count is 0 </returns>
        [HttpGet]
        [Route("api/Assignment2/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string menu(int burger, int drink, int side, int dessert)
        {
            int burgerCalories;
            int drinkCalories;
            int sideCalories;
            int dessertCalories;
            int totalCalories = 0;
            string message = "Your total calorie count is ";
            string finalMessage;

            if(burger == 1)
            {
                burgerCalories = 461;
                totalCalories = totalCalories + burgerCalories;
         
            } 
            else if(burger == 2)
            {
                burgerCalories = 431;
                totalCalories = totalCalories + burgerCalories;
            }
            else if (burger == 3)
            {
                burgerCalories = 420;
                totalCalories = totalCalories + burgerCalories;
            }
            else
            {
                burgerCalories = 0;
                totalCalories = totalCalories + burgerCalories;
            }


            if (drink == 1)
            {
                drinkCalories = 130;
                totalCalories = totalCalories + drinkCalories;
            }
            else if (drink == 2)
            {
                drinkCalories = 160;
                totalCalories = totalCalories + drinkCalories;
            }
            else if (drink == 3)
            {
                drinkCalories = 118;
                totalCalories = totalCalories + drinkCalories;
            }
            else
            {
                drinkCalories = 0;
                totalCalories = totalCalories + drinkCalories;
            }

            if (side == 1)
            {
                sideCalories = 100;
                totalCalories = totalCalories + sideCalories;
            }
            else if (side == 2)
            {
                sideCalories = 57;
                totalCalories = totalCalories + sideCalories;
            }
            else if (side == 3)
            {
                sideCalories = 70;
                totalCalories = totalCalories + sideCalories;
            }
            else
            {
                sideCalories = 0;
                totalCalories = totalCalories + sideCalories;
            }

            if (dessert == 1)
            {
                dessertCalories = 167;
                totalCalories = totalCalories + dessertCalories;
            }
            else if (dessert == 2)
            {
                dessertCalories = 266;
                totalCalories = totalCalories + dessertCalories;
            }
            else if (dessert == 3)
            {
                dessertCalories = 75;
                totalCalories = totalCalories + dessertCalories;
            }
            else
            {
                dessertCalories = 0;
                totalCalories = totalCalories + dessertCalories;
            }

            finalMessage = message + totalCalories;
            return finalMessage;

        }


        /// <summary>
        /// This method returns a string that calculates how many ways 10 can be rolled based on the value of two die
        /// </summary>
        /// <example>GET api/Assignment2/J2/diceGame/6/8 </example>
        /// <param name="m"> an INT value representing the number of sides on die #1 </param>
        /// <param name="n"> an INT value representing the number of sides on die #2 </param>
        /// <returns> There are 5 total ways to get the sum 10. </returns>
        [HttpGet]
        [Route("api/Assignment2/J2/diceGame/{m}/{n}")]
        public string diceGame(int m, int n)
        {
            int countOfSum = 0;
            string finalMessage;
            string message;
            

            for(int d1 = 1; d1 <= m; d1++)
            {
                for(int d2 = 1; d2 <= n; d2++)
                {
                    int sum = d1 + d2;               

                    if(sum == 10)
                    {
                        countOfSum++;
                    }
                }

            }

            if(countOfSum == 1)
            {
                finalMessage = "There is " + countOfSum + " way to get the sum 10.";
            } 
            else if(countOfSum >= 5)
            {
                finalMessage = "There are " + countOfSum + " total ways to get the sum 10.";
            }
            else
            {
                finalMessage = "There are " + countOfSum + " ways to get the sum 10.";
            }
            
            return finalMessage;
        }



        [HttpGet]
        [Route("api/Assignment2/J3/Punchy/{number}/{letter}/{value}")]
        public string punchy(int number, string letter, char value)
        {
            // int[,] theArray = { { 1, 2 }, { 2, 3 }, { 3, 4 } };

            //int[,] v = theArray[0][1];

            // Problem J3 - Punchy - 2010
            // What I am attempting to do to solve the question
            // 1. Take in the desired input, To me a nested array seems to make the most sense as an input
            // 2. Loop through each array within the nested array. Each array will be formated like this [number, letter, value] following the format of the sample input.
            // 3. Each element of the array will then be inputed into the logic of the method/function

            int A = 0;
            int B = 0;

            if(number == 1)
            {
                letter = value;
            } 


            return "This is the number: " + number + " this is the string: " + letter + " this is the char: " + value ;

        }
    }
}
    



