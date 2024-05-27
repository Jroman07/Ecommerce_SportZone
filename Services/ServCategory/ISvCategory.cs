
namespace Services.Category
{
    public interface ISvCategory
    {
        //reads
        public List<Entidades.Category> GetAllCategories();

        public Entidades.Category GetCategoryById(int id);

        //writes
        public Entidades.Category AddCategory(Entidades.Category category);

        public Entidades.Category UpdateCategory(int id, Entidades.Category category);

        public void DeleteCategory(int id);
    }
}
