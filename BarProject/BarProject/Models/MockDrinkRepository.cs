using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarProject.Models
{
    public class MockDrinkRepository : IDrinkRepository
    {
        public Queue<Drink> _drinkQueue;

        public MockDrinkRepository()
        {
            _drinkQueue = new Queue<Drink>();
            //Drink drink1 = new Drink() { Name = "the drink", Shakers = "shaker", Liquors = "rum", Mixes = "mix", Glasses = "glass", Garnishes = "leaf" };
            //Drink drink2 = new Drink() { Name = "the drink2", Shakers = "shaker2", Liquors = "rum2", Mixes = "mix2", Glasses = "glass2", Garnishes = "leaf2" };
            //_drinkQueue.Enqueue(drink1);
            //_drinkQueue.Enqueue(drink2);
        }

        public Drink Add(Drink drink)
        {
            _drinkQueue.Enqueue(drink);
            return drink;
        }

        public Drink Delete()
        {
            if (_drinkQueue.Count > 0)
            {
                Drink servedDrink = _drinkQueue.Dequeue();
                return servedDrink;
            }
            return null;
        }

        public Array GetAllDrinks()
        {
            Array displayQueue = _drinkQueue.ToArray();
            return displayQueue;
        }
    }
}
