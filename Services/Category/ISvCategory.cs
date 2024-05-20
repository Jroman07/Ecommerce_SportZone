using Proyecto_SportZone;

namespace Services.Category
{
    public interface ISvCategory
    {
        //reads
        public List<Categoria> GetAllCategories();

        public Categoria GetCategoryById(int IdCategory);

        //writes
        public Categoria AddCategory(Categoria category);
    }
}
