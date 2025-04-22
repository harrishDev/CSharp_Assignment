﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech_Shop.Entities;

namespace Tech_Shop.DAO
{
    public interface ICustomerDAO
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
    }
}