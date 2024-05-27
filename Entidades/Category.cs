
namespace Entidades
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public bool IsActive { get; private set; }
        public List<Shoe>? Shoes { get; set; }

        public Category() { IsActive = true; }

        public void ChangeIsActive() { IsActive = false; }
    }
}
