using Proyecto_SportZone;

namespace Services.Category
{
    public interface ISvCategory
    {
        //reads
        public List<Proyecto_SportZone.Category> GetAllCategories();

        public Proyecto_SportZone.Category GetCategoryById(int IdCategory);

        //writes
        public Proyecto_SportZone.Category AddCategory(Proyecto_SportZone.Category category);
    }
}
