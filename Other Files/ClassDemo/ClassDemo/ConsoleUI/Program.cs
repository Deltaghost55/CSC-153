using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            /**
             * We can go ahead and create objects from the Player class as we
             * load those objects into the array. This would require use to
             * know how many objects and what those values are going to be
             * in the first place.
             */
            //ClassDemoLibrary.Player[] players = { new ClassDemoLibrary.Player("William", "Buckwell", 100),
            //                                       new ClassDemoLibrary.Player("Thor", "Buckwell", 100),
            //                                        new ClassDemoLibrary.Player("William", "Blackwell", 100)};

            /**
             * We can create an empty List with the Player datatype. This will allow
             * us to add objects of that datatype as the program runs.
             */
            List<ClassDemoLibrary.Player> players2 = new List<ClassDemoLibrary.Player>();

            do
            {
                Console.WriteLine(ClassDemoLibrary.StandardMessages.Menu());

                switch(Console.ReadLine())
                {
                    case "1":
                        //ClassDemoLibrary.Player yourPlayer = new ClassDemoLibrary.Player();

                        //yourPlayer.FirstName = "William";
                        //yourPlayer.LastName = "Buckwell";
                        //yourPlayer.Health = 100;

                        //players2.Add(yourPlayer);

                        // This is were we pass our list to the method so we can add a new
                        // object we create with the user informaton.
                        ClassDemoLibrary.BuildPlayer.BulidAPlayer(players2);

                        // Since we did not name the object when we added it to the array then
                        // we must call it from its postion in the array.
                        Console.WriteLine(ClassDemoLibrary.StandardMessages.ShowPlayer(players2[ClassDemoLibrary.Player.Count - 1]));

                        // This will display the number of objects we have created from this class.
                        // This property is a static property so it is shared amoung the objects
                        // and is not created in any one object.
                        Console.WriteLine(ClassDemoLibrary.Player.Count);
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(ClassDemoLibrary.StandardMessages.DisplayChoiceError());
                        break;

                }

                //ClassDemoLibrary.Player myPlayer = new ClassDemoLibrary.Player();

                //Console.WriteLine(myPlayer.Health);
            } while (exit == false);
    
        }
    }
}
