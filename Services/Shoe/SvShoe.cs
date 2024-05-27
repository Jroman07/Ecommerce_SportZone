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
            _myDbContext.Shoes.Add(shoe);
            _myDbContext.SaveChanges();
            return shoe;
        }
        public void DeleteShoe(int id)
        {
            Shoes deleCustomer = _myDbContext.Shoes.Find(id);
            if (deleCustomer != null)
            {
                deleCustomer.IsActive= false;
                _myDbContext.Update(deleCustomer);
                _myDbContext.SaveChanges();
            }
        }
        public List<Shoes> GetAllShoes()
        {
            return _myDbContext.Shoes.ToList();
        }

        public Shoes GetShoeById(int id)
        {
            return _myDbContext.Shoes.Find(id);
        }

        public Shoes UpdateShoe(int id, Shoes shoe)
        {
            Shoes shoesUpdate = _myDbContext.Shoes.Find(id);
            shoesUpdate.Name = shoe.Name;
            shoesUpdate.Price = shoe.Price;
            shoesUpdate.Stock = shoe.Stock;
            shoesUpdate.Size = shoe.Size;

            _myDbContext.Update(shoesUpdate);
            _myDbContext.SaveChanges();
             
            return shoesUpdate;
        }
    }
}
