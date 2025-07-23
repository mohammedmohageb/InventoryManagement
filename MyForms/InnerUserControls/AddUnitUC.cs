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

namespace InventoryManagement.MyForms.InnerUserControls
{
    public partial class AddUnitUC : UserControl
    {
        public MainForm main;
        public AddUnitUC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btn_back_to_product_from_unit_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            Products_UC products_us = new Products_UC(main);
            products_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(products_us);
        }
    }
}
