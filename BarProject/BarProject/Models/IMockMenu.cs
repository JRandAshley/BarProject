using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarProject.Models
{
    public interface IMockMenu
    {
        List<Drink> GetAllDrinks();
        Drink Add(Drink drink);
        Drink Delete(String name);
    }
}
