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
        public Invoices AddInvoice(Invoices newInvoice)
        {
            throw new NotImplementedException();
        }

        public Invoices GetAllInvoices()
        {
            throw new NotImplementedException();
        }

        public Invoices GetInvoiceById(int invoiceId)
        {
            throw new NotImplementedException();
        }
    }
}
