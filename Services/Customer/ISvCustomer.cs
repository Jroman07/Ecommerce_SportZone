﻿using Proyecto_SportZone;
namespace Services.Customer
{
    public interface ISvCustumer
    {
        public Cliente Addcustomer(Cliente customer);

        public List<Cliente> GetAllcustomer();

        public Cliente GetCostumerById(int id);

        public Cliente UpdateCustomer(int id, Cliente customer);

        public Cliente DeleteCustomer(int id);

        public bool SearchByEmail(string _email);
    }
}
