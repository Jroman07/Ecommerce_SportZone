
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
            _myDbContext.Categories.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }

        public void DeleteCategory(int id)
        {
            Entidades.Category deleteCategory = _myDbContext.Categories.Find(id);
            if (deleteCategory != null)
            {
                //_myDbContext.Customers.Remove(deleteCustomer);
                deleteCategory.ChangeIsActive();
                _myDbContext.Categories.Update(deleteCategory);
                _myDbContext.SaveChanges();
            }
        }
        #endregion

        #region Reads
        public List<Entidades.Category> GetAllCategories()
        {
            return _myDbContext.Categories.Include(x => x.Shoes).Where(Category => Category.IsActive).ToList();
        }

        public Entidades.Category GetCategoryById(int id)
        {
            return _myDbContext.Categories.Where(Categoria => Categoria.IsActive).Include(x => x.Shoes).SingleOrDefault(x => x.Id == id);
        }

        public Entidades.Category UpdateCategory(int id, Entidades.Category category)
        {
            Entidades.Category categoryUpdate = _myDbContext.Categories.Find(id);
            categoryUpdate.Name = category.Name;

            _myDbContext.Update(categoryUpdate);
            _myDbContext.SaveChanges();

            return categoryUpdate;
        }

        #endregion
    }
}
