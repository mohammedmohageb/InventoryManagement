using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UserControls
{
    public partial class Products_UC : UserControl
    {
        public Products_UC()
        {
            InitializeComponent();
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
    }
}
