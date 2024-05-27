using Entidades;
using Services.MyDbContext;

namespace Services.Invoice
{
    public class SvInvoice : ISvInvoice
    {
        private MyContext _myDbContext = default!;
        public SvInvoice()
        {
            _myDbContext = new MyContext();
        }


     #region Writes
        public Entidades.Invoice AddInvoice(Entidades.Invoice newInvoice)
        {
            throw new NotImplementedException();
        }
     #endregion


     #region Reads
        public Entidades.Invoice GetAllInvoices()
        {
            throw new NotImplementedException();
        }

        public Entidades.Invoice GetInvoiceById(int invoiceId)
        {
            throw new NotImplementedException();
        }
        
    }
    #endregion
}
