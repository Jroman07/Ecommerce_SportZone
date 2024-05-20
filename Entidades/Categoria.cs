
namespace Proyecto_SportZone
{
    public class Categoria
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public bool IsActive = true;
        public List<Shoes>? Shoes { get; set; }
    }
}
