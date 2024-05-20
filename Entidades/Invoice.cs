using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SportZone
{
    public class Invoices
    {
        public int Id { get; set; }
        public int IdCostumer { get; set; }
        public Cliente customer { get; set; }
        public List<Shoes>? shoes { get; set; }
    }
}
