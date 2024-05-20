using Proyecto_SportZone;
using Services.MyDbContext;

namespace Services.Shoe
{
    public class SvShoe : ISvShoe
    {
        private MyContext _myDbContext = default!;
        public SvShoe()
        {
            _myDbContext = new MyContext();
        }
        public Shoes AddShoe(Shoes shoe)
        {
            throw new NotImplementedException();
        }

        public void DeleteShoe(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shoes> GetAllShoes()
        {
            throw new NotImplementedException();
        }

        public Shoes GetShoeById(int id)
        {
            throw new NotImplementedException();
        }

        public Shoes UpdateShoe(int id, Shoes shoe)
        {
            throw new NotImplementedException();
        }
    }
}
