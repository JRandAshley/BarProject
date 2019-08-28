using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarProject.Models
{
    public class SQLMenuRepository : IMockMenu
    {
        private readonly AppDbContext context;

        public SQLMenuRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Drink Add(Drink drink)
        {
            context.Drinks.Add(drink);
            context.SaveChanges();
            return drink;
        }

        public Drink Delete(String name)
        {
            Drink drink = context.Drinks.Find(name);
            if(drink != null)
            {
                context.Drinks.Remove(drink);
                context.SaveChanges();
            }
            return drink;
        }

        public List<Drink> GetAllDrinks()
        {
            return context.Drinks.ToList<Drink>();
        }
    }
}
