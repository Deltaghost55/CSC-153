using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDemoClassLibrary
{
    public class Creature
    {
        // fields
        private string _name;
        private string _description;
        private int _ac;
        private int _hitPoints;

        // Constructor
        public Creature()
        {
            Name = "No Name";
            Description = "No Descrp";
            AC = 0;
            HitPoints = 0;
            Mana = 0;
        }

        public Creature(string name, string descrip, int ac, int hp, int mana)
        {
            Name = name;
            Description = descrip;
            AC = ac;
            HitPoints = hp;
            Mana = mana;
        }

        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public int AC
        {
            get
            {
                return _ac;
            }
            set
            {
                _ac = value;
            }
        }

        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
            }
        }

        public int Mana { get; set; }


        // TODO Methods
        public static void RegenarateMana()
        {
            // TODO create code to regen mana
        }

        public static string LookRoom(Room inputRoom)
        {
            // TODO create code to look at look

            return inputRoom.Description;
        }
    }
}
