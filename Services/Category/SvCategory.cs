
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
        public Proyecto_SportZone.Category AddCategory(Proyecto_SportZone.Category category)
        {
            _myDbContext.Categorias.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }
        #endregion

        #region Reads
        public List<Proyecto_SportZone.Category> GetAllCategories()
        {
            return _myDbContext.Categorias.Include(x => x.Shoes).ToList();
        }

        public Proyecto_SportZone.Category GetCategoryById(int IdCategory)
        {
            return _myDbContext.Categorias.Include(x => x.Shoes).ToList()[IdCategory];
        }
        #endregion
    }
}
