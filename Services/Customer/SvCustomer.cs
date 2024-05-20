using Proyecto_SportZone;
using Services.MyDbContext;

namespace Services.Customer
{
    public class SvCustomer : ISvCustumer
    {
        private MyContext _myDbContext = default!;
        public SvCustomer()
        {
            _myDbContext = new MyContext();
        }

        public Cliente Addcustomer(Cliente customer)
        {
            throw new NotImplementedException();
        }

        public Cliente DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAllcustomer()
        {
            throw new NotImplementedException();
        }

        public Cliente GetCostumerById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SearchByEmail(string _email)
        {
            throw new NotImplementedException();
        }

        public Cliente UpdateCustomer(int id, Cliente customer)
        {
            throw new NotImplementedException();
        }
    }
}
