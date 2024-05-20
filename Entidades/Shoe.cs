namespace Proyecto_SportZone
{
    public class Shoes
    {
        public int Id { get; set; }
        public float Size { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public bool IsActive = true;
        public int IdCategory { get; set; }
        public Categoria? Category { get; set; }
    }
}
