namespace Entidades
{
    public class Shoe
    {
        public int Id { get; set; }
        public float Size { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; private set; }
        //
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public Shoe() { IsActive = true; }
        public void ChangeIsActive() { IsActive = false; }
    }
}
