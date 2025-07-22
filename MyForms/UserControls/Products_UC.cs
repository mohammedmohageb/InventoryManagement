using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.InnerUserControls;

namespace InventoryManagement.UserControls
{
    public partial class Products_UC : UserControl
    {
        public MainForm main;
        public Products_UC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void DGV_product_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void btn_save_modfiy_product_Click(object sender, EventArgs e)
        {

        }
        private void Products_UC_Load(object sender, EventArgs e)
        {
            btn_save_modfiy_product.Enabled = false;
            btn_save_new_product.Enabled = false;
            btn_cancel.Enabled = false;
        }

        private void btn_add_cateory_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            AddCategory products_us = new AddCategory(main);
            products_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(products_us);
        }
    }
}
