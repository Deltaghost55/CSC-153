using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoLibrary
{
    public class Player
    {
        // Fields
        private string _firstName;
        private string _lastName;
        //private static int _count = 0;

        // Constructers
            // Default
        public Player ()
        {
            FirstName = "";
            LastName = "";
            Health = 0;
            Count++;
        }

            // Custom
        public Player (string firstName, string lastName, int health)
        {
            FirstName = firstName;
            LastName = lastName;
            Health = health;
            Count++;
        }


        // Full Properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return _firstName + " " + _lastName;
            }
        }

        // Auto Property
        // No Backing Fields
        public int Health { get; set; }

        // Static property is shared among the objects but is not 
        // truely own by any one object
        public static int Count { get; set; } = 0;


    }
}
