namespace Entidades
{
    public class PurchaseDetail
    {
        public int Id { get; set; }
        public int IdShoe { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Subtotal => Quantity * Price;

        public Shoe? Shoe { get; set; }
    }
}
