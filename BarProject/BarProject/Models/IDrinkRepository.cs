using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarProject.Models
{
    public interface IDrinkRepository
    {
        Array GetAllDrinks();
        Drink Add(Drink drink);
        Drink Delete();
    }
}
