using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTRON_Management_Software.Utils
{
    class PasswordGenerator
    {
        //Possible Characters
        static char[] upperCaseLetters = new char[]{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static char[] lowerCaseLetters = new char[]{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static char[] possibleNumbers =new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char[] possibleSpecialCharacters = new char[]{ '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=' };

        //Array of possible combination
        char[][] possibleCombinations = new char[4][] { upperCaseLetters, lowerCaseLetters, possibleNumbers, possibleSpecialCharacters };

     //Method that generates random Number in between range
        private int getRandomNumber(int min,int max)
        {
            Random r = new Random();
            int randomNumber = r.Next(min, max);
            return randomNumber;
        }
        //Method that generates random password and returns it
        public string generatePassword()
        {
            int index;
            string password = "";
            //Here 6 is default password length
            for (index = 0; index < 6; index++)
            {
                int randomNumber = getRandomNumber(0, possibleCombinations.Length);
                char[] pickedArray = possibleCombinations[randomNumber];
                randomNumber = getRandomNumber(0, pickedArray.Length);
                string pickedLetters = pickedArray[randomNumber].ToString();
                password +=pickedLetters;

            }
            return password;
        }
    }
}
//webTRON Management Software