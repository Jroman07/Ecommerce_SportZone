
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


        #region Writes
        public Entidades.Shoe AddShoe(Entidades.Shoe shoe)
        {
            _myDbContext.Shoes.Add(shoe);
            _myDbContext.SaveChanges();
            return shoe;
        }
       

        public void DeleteShoe(int id)
        {
            Entidades.Shoe deleteShoe = _myDbContext.Shoes.Find(id);
            if (deleteShoe != null)
            {
                 deleteShoe.ChangeIsActive();
                _myDbContext.Shoes.Update(deleteShoe);
                _myDbContext.SaveChanges();
            }
        }
        public Entidades.Shoe UpdateShoe(int id, Entidades.Shoe shoe)
        {
            Entidades.Shoe shoesUpdate = _myDbContext.Shoes.Find(id);
            shoesUpdate.Name = shoe.Name;
            shoesUpdate.Price = shoe.Price;
            shoesUpdate.Stock = shoe.Stock;
            shoesUpdate.Size = shoe.Size;

            _myDbContext.Shoes.Update(shoesUpdate);
            _myDbContext.SaveChanges();

            return shoesUpdate;
        }
        #endregion


        #region Reads
        public List<Entidades.Shoe> GetAllShoes()
        {
            return _myDbContext.Shoes.ToList();
        }

        public Entidades.Shoe GetShoeById(int id)
        {
            return _myDbContext.Shoes.Find(id);
        }

    }
    #endregion
}
