using Proyecto_SportZone;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
