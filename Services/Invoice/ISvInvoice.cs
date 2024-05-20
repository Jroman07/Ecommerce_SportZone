using Proyecto_SportZone;

namespace Services.Invoice
{
    public interface ISvInvoice
    {
        public Invoices AddInvoice(Invoices newInvoice);
        public Invoices GetInvoiceById(int invoiceId);
        public Invoices GetAllInvoices();
    }
}
