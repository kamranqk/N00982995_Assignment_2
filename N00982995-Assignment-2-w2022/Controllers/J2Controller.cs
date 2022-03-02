using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_2_w2022.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// The Dice Game takes two numbers m,n.
        /// finds the posible combination for the
        /// numbers m (form 1 to m) and n (from 1 to n) equals to 10.
        /// </summary>
        /// <param name="m">Total number of sides for die one</param>
        /// <param name="n">Total number of sides for die two</param>
        /// <returns> Posible combination of number 10</returns>
        /// 
        /// For example:
        /// 
        /// Get  api/j2/DiceGame/5/5
        /// Get  api/j2/DiceGame/m/n
        /// There are two FOR loops to caluculate the possible
        /// combination of two number 5 and 5 equals to 10.
        /// The intial counter values for both FOR loops set to 1.
        /// Both FOR loops condition is set to less than and equal 
        /// to 5 (m=5,n=5). And increment by 1 each time.
        /// First FOR loop enter 5 times in 2nd FOR loop...
        /// IF statement (Counter1 + Counter2) = 10    
        /// (1 + 1) = 10
        /// (1 + 2) = 10
        /// (1 + 3) = 10
        /// (1 + 4) = 10
        /// (1 + 5) = 10
        /// (2 + 1) = 10
        /// (2 + 2) = 10
        /// (3 + 3) = 10
        /// 
        ///  and so on..
        /// 
        /// (5 + 5) = 10
        ///
        /// IF statement in 2nd loop add both counters for the 
        /// possible combination of 10.
        /// 
        /// Each time counters sum is
        /// equal to 10.
        /// 
        /// Total combination value incremented by 1.	
        /// 
        ///  output -> There is 1 way to get the sum 10.
        ///  
        //// GET : api/J2/DiceGame
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {

            int DieOne = 1;                               // intialize the counter one to 1
            int DieTwo = 1;                               // intialize the counter two to 1
            int totalCombination = 0;                     // intialize total combination to 0

            for (DieOne = 1; DieOne <= m; DieOne++)                // FOR loop enters 2nd FOR loop "m" times and increment each time by 1
            {

                for (DieTwo = 1; DieTwo <= n; DieTwo++)           // FOR loop adds the counters of both FOR loops "n" times and increment each time by 1
                {

                    if (DieOne + DieTwo == 10)                    // if statement both counters sum equal to 10
                    {
                        totalCombination = totalCombination + 1;   // increment the total combination by 1

                    }
                }
            }
            if (totalCombination == 1)                                                     // if statement total combination equals to 1 
            {
                return "There is " + totalCombination + " way to get the sum 10.";         // return this msg 
            }
            else if (totalCombination == 0 || totalCombination == 4)                       // if statement total combination equals to 0 or 4
            {
                return "There are " + totalCombination + " ways to get the sum 10.";       // return this msg 
            }
            else
            {
                return "There are " + totalCombination + " total ways to get the sum 10."; // for any other total combination return this msg
            }
        }
    }
}
