using GENERIC_TASK_FINAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_TASK_FINAL.Classes
{
    public class FastFood :IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Indrigients { get; set; }
    }
}

