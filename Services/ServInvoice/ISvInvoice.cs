

namespace Services.Invoice
{
    public interface ISvInvoice
    {
        //Writes
        public Entidades.Invoice AddInvoice(Entidades.Invoice newInvoice);
       
        //Reads
        public Entidades.Invoice GetInvoiceById(int invoiceId);
        public Entidades.Invoice GetAllInvoices();
    }
}
