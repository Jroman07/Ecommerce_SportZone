using Proyecto_SportZone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Shoe
{
    public interface ISvShoe
    {
        //READS
        public List<Shoes> GetAllShoes();
        public Shoes GetShoeById(int id);

        //WRITES
        public Shoes AddShoe(Shoes shoe);
        public Shoes UpdateShoe(int id, Shoes shoe);
        public void DeleteShoe(int id);
    }
}
