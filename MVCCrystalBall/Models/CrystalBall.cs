using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrystalBall.Models
{
    public class CrystalBall
    {

        //create an array of strings for responses
        //get random number


        public string getResponses()
        {
            string[] responses = { "You are loved", "It's best to serve soup warm", "You will be very fortunate", "You are going on a long journey","Life will be bliss" };
            //get random number object
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length);
            return responses[num];
        }

    }
}