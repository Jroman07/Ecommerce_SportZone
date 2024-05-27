
namespace Services.Category
{
    public interface ISvCategory
    {
        //reads
        public List<Entidades.Category> GetAllCategories();

        public Entidades.Category GetCategoryById(int IdCategory);

        //writes
        public Entidades.Category AddCategory(Entidades.Category category);
    }
}
