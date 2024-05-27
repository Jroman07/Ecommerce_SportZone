namespace Entidades
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; private set; }
        public int IdCostumer { get; set; }
        public double Total => PurchaseDetails.Sum(x => x.Subtotal);

        public List<PurchaseDetail>? PurchaseDetails { get; set; }
        public Customer? Cliente { get; set; }

        public Invoice() { InvoiceDate = DateTime.Now; }
    }
}
