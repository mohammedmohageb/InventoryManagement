using InventoryManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            Home_UC h = new Home_UC();
            h.Dock = DockStyle.Fill;
            panelhome.Controls.Add(h);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnhome.Enabled = false;
            btnproducts.Enabled = false;
            btnsuppliers.Enabled = false;
            btncustomers.Enabled = false;
            btntransactions.Enabled = false;
            btnreports.Enabled = false;
            this.Show();
            Login log = new Login(this);
            log.ShowDialog();
        }
    }
}
