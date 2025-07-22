using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.UserControls;

namespace InventoryManagement.InnerUserControls
{
    public partial class AddCategory : UserControl
    {
        public MainForm main;
        public AddCategory(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            btn_save_category.Enabled = false;
            btn_cancel_category.Enabled = false;
        }

        private void btn_back_to_product_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            Products_UC products_us = new Products_UC(main);
            products_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(products_us);
        }
    }
}
