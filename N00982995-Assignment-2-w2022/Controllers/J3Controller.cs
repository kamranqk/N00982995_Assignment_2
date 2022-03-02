/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_2_w2022.Controllers
{
    public class J3Controller : ApiController
    {
        /// Initiative to create a WebAPI Method for J3 problem
        /// 
        /// <summary>
        /// For each input word the Cell Phone function out put the minimal number of
        ///  seconds needed to type in the word, with one number of output per line.
        /// </summary>
        /// 
        /// <param name="letterOne"></param>
        /// <param name="letterTwo"></param>
        /// <param name="letterThree"></param>
        /// <param name="letterFour"></param>
        /// 
        /// <returns>number of seconds to type in the word</returns>
        /// 
        /// For example:
        /// bob
        /// 2266622 = 7 seconds
        /// 
        /// if (input == "halt")
        /// and the program will stop reading input when the word halt has been entered.
        /// 
        /// while loop runs n times to calculate the time in seconds
        /// where counter i = 1 and is less than and equal to 26 
        /// previous letter is defined to add time-out
        /// alphabet array is used to store time in seconds
        /// and each previous letter equals to current letter the seconds counter is bumped by 1
        /// time in seconds is displyed.
        /// 
        /// output -> 7 
        /// 
        /// GET : api/J3/CellPhone
        
        [HttpGet]
        [Route("api/J3/CellPhone/letterOne}/{letterTwo}/{letterThree}/{letterFour}")]
        public string CellPhone(string letterOne, string letterTwo, string letterThree, string letterFour)
        {
            int time; //time in seconds
            int i = 1; // counter is equal to 1
            int n = 26; // number of alphabets
            int second = 0; // seconds take to input the letters
            string previousLetter = ""; // previous letter to calculated time-out


            List<int> alphabetTimeArray = new List<int> { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 }; // time array to calculate time in seconds

            string input = letterOne + letterTwo + letterThree + letterFour; // concatenated the user input together


            while (i <= n) // to run the while loop to the limit
            {
                if (input == "halt") ; //  the program will stop reading input when the word halt has been entered
                break;
                if (previousLetter = alphabetTimeArray[i]) ; // previous letter of input to add time-out
                {
                    int seconds = alphabetTimeArray[i]; // given index to time array to calulate time in seconds
                    time = second++; // to add extra second due to repeted letter
                }
                i++; // increment counter by 1
            }
            return time; // return time in seconds

        }
    }
}
*/