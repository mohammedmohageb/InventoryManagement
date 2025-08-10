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
    class CustomerDAL
    {
        // تعريف متغير من نوع SqlCommand لاستخدامه في تنفيذ أوامر SQL
        private SqlCommand cmd;

        // دالة لجلب جميع العملاء من قاعدة البيانات وإرجاعها في DataTable
        public DataTable GetAllCustomers()
        {
            // إنشاء جدول بيانات مؤقت لتخزين النتائج
            DataTable dt = new DataTable();

           
            SqlConnection conn = DBConnection.GetConnectionString();

            try
            {
                
                conn.Open();

                // تعريف استعلام SQL لاختيار بيانات العملاء
                string query = @"
                SELECT
                    Customer_ID,
                    Customer_Name, 
                    Customer_Phone
                FROM Customers";

                // استخدام SqlDataAdapter لملء DataTable بالبيانات المسترجعة من الاستعلام
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            // إعادة جدول البيانات الذي يحتوي على جميع العملاء
            return dt;
        }

        public void AddCustomer(string customerName, string customerPhone)
        {
            SqlConnection conn = DBConnection.GetConnectionString();

            try
            {
               
                conn.Open();

                // تعريف أمر الإدخال لإضافة بيانات العميل الجديد
                string query = "INSERT INTO Customers (Customer_Name, Customer_Phone) VALUES (@name, @phone)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // تعيين قيم المعاملات (Parameters) في أمر SQL لتجنب هجمات الحقن SQL Injection
                cmd.Parameters.AddWithValue("@name", customerName);
                cmd.Parameters.AddWithValue("@phone", customerPhone);

                // تنفيذ أمر الإدخال في قاعدة البيانات (لا يرجع بيانات)
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        // دالة لتحديث بيانات عميل موجود باستخدام المعرف الخاص به
        public void UpdateCustomer(string customerId, string customerName, string customerPhone)
        {
            SqlConnection conn = DBConnection.GetConnectionString();

            try
            {
                
                conn.Open();

                // استعلام تحديث بيانات العميل بناءً على معرفه
                string query = "UPDATE Customers SET Customer_Name = @name, Customer_Phone = @phone WHERE Customer_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                // تعيين المعاملات لقيم جديدة وأيضاً المعرف لتحديد السطر الصحيح
                cmd.Parameters.AddWithValue("@id", customerId);
                cmd.Parameters.AddWithValue("@name", customerName);
                cmd.Parameters.AddWithValue("@phone", customerPhone);

              
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 
                conn.Close();
            }
        }

        // دالة لحذف عميل معين من قاعدة البيانات باستخدام المعرف
        public void DeleteCustomer(string customerId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();

            try
            {
                
                conn.Open();

                // أمر الحذف بناءً على معرف العميل
                string query = "DELETE FROM Customers WHERE Customer_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                // تعيين المعامل لتحديد السطر المراد حذفه
                cmd.Parameters.AddWithValue("@id", customerId);

               
                cmd.ExecuteNonQuery();
            }
            finally
            {
               
                conn.Close();
            }
        }

        // دالة للتحقق من وجود عميل في قاعدة البيانات عبر المعرف
        public bool IsCustomerExists(string customerId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();

            try
            {
                
                conn.Open();

                // استعلام لحساب عدد العملاء الذين يطابقون المعرف المعطى
                string query = "SELECT COUNT(*) FROM Customers WHERE Customer_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                // تعيين المعامل
                cmd.Parameters.AddWithValue("@id", customerId);

                // تنفيذ الاستعلام وإرجاع العدد (عدد السجلات المطابقة)
                int count = (int)cmd.ExecuteScalar();

                // إرجاع true إذا وجد العميل، false إذا لم يوجد
                return count > 0;
            }
            finally
            {
               
                conn.Close();
            }
        }
    }



}
