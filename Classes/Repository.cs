
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Escape.Classes
{
    public static class Repository
    {
        public static List<Item> GetStartingItems()
        {
            List<Item> startingItems = new List<Item>();
            startingItems.Add(new Item("Match Of Fire", 1));
            startingItems.Add(new Item("Dry Wooden stick", 1));
            return startingItems;
        }
        public static List<Item> GetTorch()
        {
            List<Item> torch = new List<Item>();
            torch.Add(new Item("Torch Of Light", 1));
            return torch;
        }

        public static List<Item> getKeyRoom01()
        {
            List<Item> keyRoom01 = new List<Item>();
            keyRoom01.Add(new Item("The Ancient Key", 1));
            return keyRoom01;

        }

        public static List<Item> GetDices()
        {
            List<Item> dice = new List<Item>();
            dice.Add(new Item("The Dice Of Fury", 1));
            dice.Add(new Item("The Dice Of Death", 1));
            return dice;
        }

        public static List<Item> GetKeyRoom02()
        {
            List<Item> keyRoom02 = new List<Item>();
            keyRoom02.Add(new Item("The Fire Key", 1));
            return keyRoom02;
        }

        public static Room GetRoom01()
        {
            List<Item> keyRoom01 = getKeyRoom01();
            Room room01 = new Room("Room of hell, (1/2)", false, 1, 1, keyRoom01);
            return room01;
        }

        public static Room GetRoom02()
        {
            List<Item> diceRoom02 = GetDices();
            Room room02 = new Room("Room of TEARS, (2/2)", true, 1, 1, diceRoom02);
            return room02;
        }


    }
}
