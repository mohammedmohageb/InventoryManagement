using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using InventoryManagement.ConnectionString;

namespace InventoryManagement.DAL
{
     class SupplierDAL
    {
        private SqlCommand cmd;

        public DataTable GetAllSuppliers()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = @"
            SELECT
                Supplier_ID,
                Supplier_Name, 
                Supplier_Phone
            FROM Suppliers";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void AddSupplier( string supplierName, string supplierPhone)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "INSERT INTO Suppliers ( Supplier_Name, Supplier_Phone) VALUES ( @name, @phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", supplierName);
                cmd.Parameters.AddWithValue("@phone", supplierPhone);
                cmd.ExecuteNonQuery();
                
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateSupplier(string supplierId, string supplierName, string supplierPhone)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "UPDATE Suppliers SET Supplier_Name = @name, Supplier_Phone = @phone WHERE Supplier_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", supplierId);
                cmd.Parameters.AddWithValue("@name", supplierName);
                cmd.Parameters.AddWithValue("@phone", supplierPhone);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteSupplier(string supplierId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "DELETE FROM Suppliers WHERE Supplier_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", supplierId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public bool IsSupplierExists(string supplierId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Suppliers WHERE Supplier_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", supplierId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
