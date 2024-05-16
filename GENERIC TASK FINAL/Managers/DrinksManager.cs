using GENERIC_TASK_FINAL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GENERIC_TASK_FINAL.Interface.IGeneric;

namespace GENERIC_TASK_FINAL.Managers
{
    public class DrinksManager : GenericsManager<Drinks>
    {


        public DrinksManager() : base(
            new List<Drinks>
            {
            new Drinks { Id=1,Name="Cola",Price=2},
            new Drinks { Id=2,Name="Fanta",Price=2},
            new Drinks { Id=3,Name="Water",Price=1}
            })
        {
        }
    }
}

