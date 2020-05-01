using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoLibrary
{
    public class StandardMessages
    {
        public static string Menu()
        {
            return "1. Create player\n2. Exit";
        }

        public static string ShowPlayer(Player yourPlayer)
        {
            return $"Player Name - {yourPlayer.FullName}, Health - {yourPlayer.Health}";
        }

        public static string DisplayChoiceError()
        {
            return "Not a valid choice!";
        }
    }
}
