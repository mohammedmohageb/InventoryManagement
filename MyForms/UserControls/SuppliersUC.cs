using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using InventoryManagement.ConnectionString;
using InventoryManagement.UserControls;
using InventoryManagement.BLL;
using InventoryManagement.DAL;


namespace InventoryManagement.MyForms.UserControls
{

    public partial class SuppliersUC : UserControl
    {
        private SupplierBLL supplierBLL = new SupplierBLL();
        public MainForm main;
        public SuppliersUC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = supplierBLL.GetAllSuppliers();
        }   
        ///
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString(); // أو تأخذ من المستخدم
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            supplierBLL.AddSupplier( name, phone);
            MessageBox.Show("Add Successfuly");
            btnShowAll_Click(null, null); // تحديث العرض
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                string id = dgvSuppliers.SelectedRows[0].Cells["Supplier_ID"].Value.ToString();
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();

                supplierBLL.UpdateSupplier(id, name, phone);
                btnShowAll_Click(null, null);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                string id = dgvSuppliers.SelectedRows[0].Cells["Supplier_ID"].Value.ToString();
                if (supplierBLL.DeleteSupplier(id))
                {
                    MessageBox.Show("تم الحذف بنجاح");
                    btnShowAll_Click(null, null);
                }
                else
                {
                    MessageBox.Show("المورد غير موجود");
                }
            }
        }

        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = supplierBLL.GetAllSuppliers();
        }

        private void dgvSuppliers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];
                txtName.Text = row.Cells["Supplier_Name"].Value.ToString();
                txtPhone.Text = row.Cells["Supplier_Phone"].Value.ToString();
            }
        }
    }
}
