namespace InventoryManagement.MyForms.InnerUserControls
{
    partial class AddUnitUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_unit = new System.Windows.Forms.DataGridView();
            this.unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodifyunit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndeleteunit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_unit_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_unit = new System.Windows.Forms.Button();
            this.btn_cancel_unit = new System.Windows.Forms.Button();
            this.btn_back_to_product_from_unit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_search_unit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_unit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_unit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_unit
            // 
            this.DGV_unit.AllowUserToAddRows = false;
            this.DGV_unit.AllowUserToDeleteRows = false;
            this.DGV_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_unit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitID,
            this.unitname,
            this.btnmodifyunit,
            this.btndeleteunit});
            this.DGV_unit.Location = new System.Drawing.Point(19, 357);
            this.DGV_unit.MultiSelect = false;
            this.DGV_unit.Name = "DGV_unit";
            this.DGV_unit.ReadOnly = true;
            this.DGV_unit.RowHeadersVisible = false;
            this.DGV_unit.RowTemplate.Height = 24;
            this.DGV_unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_unit.Size = new System.Drawing.Size(975, 278);
            this.DGV_unit.TabIndex = 21;
            // 
            // unitID
            // 
            this.unitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitID.FillWeight = 10F;
            this.unitID.HeaderText = "ID";
            this.unitID.Name = "unitID";
            this.unitID.ReadOnly = true;
            // 
            // unitname
            // 
            this.unitname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitname.FillWeight = 150F;
            this.unitname.HeaderText = "Unit Name";
            this.unitname.Name = "unitname";
            this.unitname.ReadOnly = true;
            // 
            // btnmodifyunit
            // 
            this.btnmodifyunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.btnmodifyunit.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnmodifyunit.FillWeight = 50F;
            this.btnmodifyunit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodifyunit.HeaderText = "";
            this.btnmodifyunit.Name = "btnmodifyunit";
            this.btnmodifyunit.ReadOnly = true;
            this.btnmodifyunit.Text = "Modfiy";
            this.btnmodifyunit.UseColumnTextForButtonValue = true;
            // 
            // btndeleteunit
            // 
            this.btndeleteunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.btndeleteunit.DefaultCellStyle = dataGridViewCellStyle2;
            this.btndeleteunit.FillWeight = 50F;
            this.btndeleteunit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeleteunit.HeaderText = "";
            this.btndeleteunit.Name = "btndeleteunit";
            this.btndeleteunit.ReadOnly = true;
            this.btndeleteunit.Text = "Delete";
            this.btndeleteunit.UseColumnTextForButtonValue = true;
            // 
            // txt_unit_name
            // 
            this.txt_unit_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_unit_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_name.Location = new System.Drawing.Point(270, 161);
            this.txt_unit_name.Name = "txt_unit_name";
            this.txt_unit_name.Size = new System.Drawing.Size(724, 38);
            this.txt_unit_name.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 59);
            this.label2.TabIndex = 19;
            this.label2.Text = "Unit Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 106);
            this.label1.TabIndex = 18;
            this.label1.Text = "Units";
            // 
            // btn_save_unit
            // 
            this.btn_save_unit.BackColor = System.Drawing.Color.Green;
            this.btn_save_unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_unit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_unit.ForeColor = System.Drawing.Color.White;
            this.btn_save_unit.Location = new System.Drawing.Point(182, 3);
            this.btn_save_unit.Name = "btn_save_unit";
            this.btn_save_unit.Size = new System.Drawing.Size(173, 37);
            this.btn_save_unit.TabIndex = 4;
            this.btn_save_unit.Text = "Save";
            this.btn_save_unit.UseVisualStyleBackColor = false;
            // 
            // btn_cancel_unit
            // 
            this.btn_cancel_unit.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancel_unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel_unit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_unit.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_unit.Location = new System.Drawing.Point(361, 3);
            this.btn_cancel_unit.Name = "btn_cancel_unit";
            this.btn_cancel_unit.Size = new System.Drawing.Size(174, 37);
            this.btn_cancel_unit.TabIndex = 5;
            this.btn_cancel_unit.Text = "Cancel";
            this.btn_cancel_unit.UseVisualStyleBackColor = false;
            // 
            // btn_back_to_product_from_unit
            // 
            this.btn_back_to_product_from_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back_to_product_from_unit.BackColor = System.Drawing.Color.Navy;
            this.btn_back_to_product_from_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back_to_product_from_unit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_product_from_unit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back_to_product_from_unit.Location = new System.Drawing.Point(819, 66);
            this.btn_back_to_product_from_unit.Name = "btn_back_to_product_from_unit";
            this.btn_back_to_product_from_unit.Size = new System.Drawing.Size(175, 37);
            this.btn_back_to_product_from_unit.TabIndex = 23;
            this.btn_back_to_product_from_unit.Text = "Back";
            this.btn_back_to_product_from_unit.UseVisualStyleBackColor = false;
            this.btn_back_to_product_from_unit.Click += new System.EventHandler(this.btn_back_to_product_from_unit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_add_unit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel_unit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save_unit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(369, 222);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 43);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // txt_search_unit
            // 
            this.txt_search_unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_unit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_unit.Location = new System.Drawing.Point(313, 313);
            this.txt_search_unit.Name = "txt_search_unit";
            this.txt_search_unit.Size = new System.Drawing.Size(535, 38);
            this.txt_search_unit.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(854, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 51);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 59);
            this.label4.TabIndex = 26;
            this.label4.Text = "Unit List";
            // 
            // btn_add_unit
            // 
            this.btn_add_unit.BackColor = System.Drawing.Color.Green;
            this.btn_add_unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_unit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_unit.ForeColor = System.Drawing.Color.White;
            this.btn_add_unit.Location = new System.Drawing.Point(3, 3);
            this.btn_add_unit.Name = "btn_add_unit";
            this.btn_add_unit.Size = new System.Drawing.Size(173, 37);
            this.btn_add_unit.TabIndex = 6;
            this.btn_add_unit.Text = "Add";
            this.btn_add_unit.UseVisualStyleBackColor = false;
            // 
            // AddUnitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search_unit);
            this.Controls.Add(this.DGV_unit);
            this.Controls.Add(this.txt_unit_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back_to_product_from_unit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddUnitUC";
            this.Size = new System.Drawing.Size(1011, 646);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_unit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_unit;
        private System.Windows.Forms.TextBox txt_unit_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save_unit;
        private System.Windows.Forms.Button btn_cancel_unit;
        private System.Windows.Forms.Button btn_back_to_product_from_unit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_search_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitname;
        private System.Windows.Forms.DataGridViewButtonColumn btnmodifyunit;
        private System.Windows.Forms.DataGridViewButtonColumn btndeleteunit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_unit;
    }
}
