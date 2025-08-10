using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using InventoryManagement.DAL;
using InventoryManagement.ConnectionString;

namespace InventoryManagement.BLL
{
    class CustomerBLL
    {
        private CustomerDAL dal = new CustomerDAL();

        public DataTable GetAllCustomers() => dal.GetAllCustomers();
        /*
         public DataTable GetAllCustomers()
        {
        return dal.GetAllCustomers();
        }
         
         */

        public void AddCustomer(string name, string phone)
            => dal.AddCustomer(name, phone);

        public void UpdateCustomer(string id, string name, string phone)
            => dal.UpdateCustomer(id, name, phone);

        public bool DeleteCustomer(string id)
        {
            if (dal.IsCustomerExists(id))
            {
                dal.DeleteCustomer(id);
                return true;
            }
            else
            {
                return false;
            }
        }

       // public DataTable SearchCustomers(string text) => dal.SearchCustomers(text);
    }

}
