using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * We will not create an object from this class. This class will only
 * be used to ask the user for information to create the Player object
 */

namespace ClassDemoLibrary
{
    public class BuildPlayer
    {
        public static void BulidAPlayer(List<Player> inputList)
        {
            Player thisPlayer = new Player();
            bool error = false;
            do
            {               

                Console.WriteLine("What is the player's first name?");
                Console.Write("=>");
                thisPlayer.FirstName = Console.ReadLine();

                Console.WriteLine("What is the player's last name?");
                Console.Write("=>");
                thisPlayer.LastName = Console.ReadLine();

                Console.WriteLine("What is the player's health?");
                Console.Write("=>");

                thisPlayer.Health = ConvertToInt(Console.ReadLine());

                /**
                 * If Health comes back greater or equal to 0 then the program
                 * will continue. If not then the program will let the user know
                 * and then loop back through the information.
                 */
                if (thisPlayer.Health < 0)
                {
                    error = true;
                    Console.WriteLine("Something went wrong with the health!!");
                }
                else
                {
                    error = false;
                }               

            } while (error == true);

            inputList.Add(thisPlayer);
        }

        /**
         * This method will be used to convert a string to an int. If it can
         * not convert the string to an int then it will return a -1
         */
        public static int ConvertToInt(string input)
        {
            int output = 0;

            if (int.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                output = -1;
                return output;
            }
        }
    }
}
