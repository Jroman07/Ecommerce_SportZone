
using Proyecto_SportZone;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.Category
{
    public class SvCategory : ISvCategory
    {
        private MyContext _myDbContext = default!;
        public SvCategory()
        {
            _myDbContext = new MyContext();
        }

        #region Writes
        public Categoria AddCategory(Categoria category)
        {
            _myDbContext.Categorias.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }
        #endregion

        #region Reads
        public List<Categoria> GetAllCategories()
        {
            return _myDbContext.Categorias.Include(x => x.Shoes).ToList();
        }

        public Categoria GetCategoryById(int IdCategory)
        {
            return _myDbContext.Categorias.Include(x => x.Shoes).ToList()[IdCategory];
        }
        #endregion
    }
}
