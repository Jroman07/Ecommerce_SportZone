using Microsoft.EntityFrameworkCore;
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
            _myDbContext.Customers.Add(customer);
            _myDbContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            Cliente deleteCustomer = _myDbContext.Customers.Find(id);
            if (deleteCustomer != null)
            {
                _myDbContext.Customers.Remove(deleteCustomer);
                _myDbContext.SaveChanges();
            }

        }

        public List<Cliente> GetAllcustomer()
        {
            return _myDbContext.Customers.ToList();
        }

        public Cliente GetCostumerById(int id)
        {
            return _myDbContext.Customers.Find(id);

        }

        /*public bool SearchByEmail(string _email)
        {
            return; //_myDbContext.Customers.Find(_email);
        }*/

        public Cliente UpdateCustomer(int id, Cliente customer)
        {
            Cliente customerUpdate = _myDbContext.Customers.Find(id);
            customerUpdate.Name = customer.Name;
            customerUpdate.Email = customer.Email;

            return customer;
        }
    }
}