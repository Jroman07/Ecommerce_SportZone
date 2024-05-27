
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
        public Entidades.Category AddCategory(Entidades.Category category)
        {
            _myDbContext.Categorys.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }
        #endregion

        #region Reads
        public List<Entidades.Category> GetAllCategories()
        {
            return _myDbContext.Categorys.Include(x => x.Shoes).ToList();
        }

        public Entidades.Category GetCategoryById(int IdCategory)
        {
            return _myDbContext.Categorys.Include(x => x.Shoes).ToList()[IdCategory];
        }
        #endregion
    }
}
