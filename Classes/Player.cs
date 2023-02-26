using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public int Life { get; set; } = 100;
        public List<Item> BagOfItems { get; set; }

        public int DecreaseLife(int damage)
        {
            Life -= damage;

            if (Life < 1)
            {
                GameOver();
            }

            return Life;
        }

        public void GameOver()
        {
            Console.WriteLine("You Are Dead. GAME OVER!");
            Environment.Exit(0);
        }

        public void Look()
        {
            Console.WriteLine($"Name: {Name.ToUpper()}");
            Console.WriteLine($"Life: {Life}%");
        }

        public void InspectBackPack()
        {
            Console.Clear();
            foreach (Item i in Program.currentPlayer.BagOfItems)
            {
                Console.WriteLine($"{i.Name}, Amount: {i.Amount}");
            }

        }

        public void RemoveItemFromBag(string item)
        {
            var newItem = BagOfItems
                         .SingleOrDefault(x => x.Name.ToLower().Contains(item.ToLower()));

            if (item != null)
            {
                BagOfItems.Remove(newItem);
                Console.WriteLine($"Removed from backpack: {newItem.Name}");
            }

        }

        public void UpdateBagWithItem(List <Item> item01, string item02)
        {
            var newItem = item01
                         .SingleOrDefault(x => x.Name.ToLower().Contains(item02.ToLower()));

            BagOfItems.Add(newItem);

            Console.WriteLine($"Added to backpack: {newItem.Name}");
        }
   

    }
}
