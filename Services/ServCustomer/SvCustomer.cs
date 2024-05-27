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


        #region Writes
        public Entidades.Customer Addcustomer(Entidades.Customer customer)
        {
            _myDbContext.Customers.Add(customer);
            _myDbContext.SaveChanges();
            return customer;
        }
        public Entidades.Customer UpdateCustomer(int id, Entidades.Customer customer)
        {
            Entidades.Customer customerUpdate = _myDbContext.Customers.Find(id);
            customerUpdate.Name = customer.Name;
            customerUpdate.Email = customer.Email;

            _myDbContext.Customers.Update(customerUpdate);
            _myDbContext.SaveChanges();

            return customerUpdate;

            
        }
        public void DeleteCustomer(int id)
        {
            Entidades.Customer deleteCustomer = _myDbContext.Customers.Find(id);
            if (deleteCustomer != null)
            {

                deleteCustomer.ChangeIsActive();
                _myDbContext.Customers.Update(deleteCustomer);
                _myDbContext.SaveChanges();
            }

        }
        #endregion


        #region Reads 
        public List<Entidades.Customer> GetAllcustomer()
        {
            return _myDbContext.Customers.ToList();
        }

        public Entidades.Customer GetCostumerById(int id)
        {
            return _myDbContext.Customers.Find(id);

        }

        public Entidades.Customer SearchByEmail(string _email)
        {
            return _myDbContext.Customers.Find(_email);
        }

       
    }
    #endregion
}