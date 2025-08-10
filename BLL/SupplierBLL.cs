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
    class SupplierBLL
    {
        
            private SupplierDAL dal = new SupplierDAL();

            public DataTable GetAllSuppliers() => dal.GetAllSuppliers();

            public void AddSupplier( string name, string phone)
                => dal.AddSupplier( name, phone);

            public void UpdateSupplier(string id, string name, string phone)
                => dal.UpdateSupplier(id, name, phone);

            public bool DeleteSupplier(string id)
            {
                if (dal.IsSupplierExists(id))
                {
                    dal.DeleteSupplier(id);
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

}

