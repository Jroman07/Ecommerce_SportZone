using Entidades;
namespace Services.Customer
{
    public interface ISvCustumer
    {
        //Writes
        public Entidades.Customer Addcustomer(Entidades.Customer customer);
        public Entidades.Customer UpdateCustomer(int id, Entidades.Customer customer);
        public void DeleteCustomer(int id);

        //Reads
        public List<Entidades.Customer> GetAllcustomer();
        public Entidades.Customer GetCostumerById(int id);
        public Entidades.Customer SearchByEmail(string _email);
    }
}
