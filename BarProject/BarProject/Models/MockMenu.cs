using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarProject.Models
{
    public class MockMenu : IMockMenu
    {
        public List<Drink> _MenuList;

        public MockMenu()
        {
            _MenuList = new List<Drink>()
                {
                    new Drink() {Name = "Cupalibra", Liquors = "Rum", Mixes = "Coke",
                    Shakers = "None", Glasses = "Standard", Garnishes = "Lime"},
                    new Drink() {Name = "Screwdriver", Liquors = "Vodka", Mixes = "Orange Juice",
                    Shakers = "None", Glasses = "Standard", Garnishes = "Orange Wedges"},
                    new Drink() {Name = "Martini", Liquors = "Vodka and Vermouth", Mixes = "None",
                    Shakers = "Standard", Glasses = "Martini Glass", Garnishes = "Olives or Lemon Twist"}
                };
        }

        public Drink Add(Drink drink)
        {
            throw new NotImplementedException();
        }

        public Drink Delete(String name)
        {
            throw new NotImplementedException();
        }

        public List<Drink> GetAllDrinks()
        {
            return _MenuList;
        }
    }
}
