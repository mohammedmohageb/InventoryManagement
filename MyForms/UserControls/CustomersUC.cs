using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.BLL;
using InventoryManagement.DAL;
using System.Windows.Forms;

namespace InventoryManagement.MyForms.UserControls
{
    public partial class CustomersUC : UserControl
    {
        private CustomerBLL customerBLL = new CustomerBLL();
        public MainForm main;
        public CustomersUC(MainForm main)
        {
            InitializeComponent();
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            this.main = main;   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            customerBLL.AddCustomer(name, phone);
            MessageBox.Show("تمت الإضافة بنجاح");
            btnShowAll_Click(null, null); // تحديث العرض
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                string id = dgvCustomers.SelectedRows[0].Cells["Customer_ID"].Value.ToString();
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();

                customerBLL.UpdateCustomer(id, name, phone);
                MessageBox.Show("تمت التعديل بنجاح");
                btnShowAll_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                string id = dgvCustomers.SelectedRows[0].Cells["Customer_ID"].Value.ToString();
                if (customerBLL.DeleteCustomer(id))
                {
                    MessageBox.Show("تم الحذف بنجاح");
                    btnShowAll_Click(null, null);
                }
                else
                {
                    MessageBox.Show("العميل غير موجود");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = customerBLL.GetAllCustomers();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtName.Text = row.Cells["Customer_Name"].Value.ToString();
                txtPhone.Text = row.Cells["Customer_Phone"].Value.ToString();
            }
        }
    }
}
