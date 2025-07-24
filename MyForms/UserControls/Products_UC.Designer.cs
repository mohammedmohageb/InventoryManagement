namespace InventoryManagement.UserControls
{
    partial class Products_UC
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
            this.DGV_product = new System.Windows.Forms.DataGridView();
            this.txt_searchproduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_save_modfiy_product = new System.Windows.Forms.Button();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.com_category_product = new System.Windows.Forms.ComboBox();
            this.com_unit_product = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_cateory = new System.Windows.Forms.Button();
            this.btn_add_unit = new System.Windows.Forms.Button();
            this.btn_save_new_product = new System.Windows.Forms.Button();
            this.btn_cancel_product = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodifyproduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndeleteproduct = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_product
            // 
            this.DGV_product.AllowUserToDeleteRows = false;
            this.DGV_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.CategoryProduct,
            this.UnitProduct,
            this.btnmodifyproduct,
            this.btndeleteproduct});
            this.DGV_product.Location = new System.Drawing.Point(16, 358);
            this.DGV_product.MultiSelect = false;
            this.DGV_product.Name = "DGV_product";
            this.DGV_product.RowHeadersVisible = false;
            this.DGV_product.RowTemplate.Height = 24;
            this.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_product.Size = new System.Drawing.Size(975, 277);
            this.DGV_product.TabIndex = 0;
            this.DGV_product.SelectionChanged += new System.EventHandler(this.DGV_product_SelectionChanged);
            // 
            // txt_searchproduct
            // 
            this.txt_searchproduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchproduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchproduct.Location = new System.Drawing.Point(448, 318);
            this.txt_searchproduct.Name = "txt_searchproduct";
            this.txt_searchproduct.Size = new System.Drawing.Size(433, 38);
            this.txt_searchproduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product List";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.Green;
            this.btn_add_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.ForeColor = System.Drawing.Color.White;
            this.btn_add_product.Location = new System.Drawing.Point(3, 3);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(225, 37);
            this.btn_add_product.TabIndex = 0;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = false;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_save_modfiy_product
            // 
            this.btn_save_modfiy_product.BackColor = System.Drawing.Color.Green;
            this.btn_save_modfiy_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_modfiy_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_modfiy_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_modfiy_product.ForeColor = System.Drawing.Color.White;
            this.btn_save_modfiy_product.Location = new System.Drawing.Point(465, 3);
            this.btn_save_modfiy_product.Name = "btn_save_modfiy_product";
            this.btn_save_modfiy_product.Size = new System.Drawing.Size(225, 37);
            this.btn_save_modfiy_product.TabIndex = 0;
            this.btn_save_modfiy_product.Text = "Save Modify";
            this.btn_save_modfiy_product.UseVisualStyleBackColor = false;
            this.btn_save_modfiy_product.Click += new System.EventHandler(this.btn_save_modfiy_product_Click);
            // 
            // txt_product_name
            // 
            this.txt_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_product_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(227, 29);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(572, 38);
            this.txt_product_name.TabIndex = 5;
            // 
            // com_category_product
            // 
            this.com_category_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.com_category_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_category_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_category_product.FormattingEnabled = true;
            this.com_category_product.Location = new System.Drawing.Point(227, 93);
            this.com_category_product.Name = "com_category_product";
            this.com_category_product.Size = new System.Drawing.Size(572, 36);
            this.com_category_product.TabIndex = 6;
            // 
            // com_unit_product
            // 
            this.com_unit_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.com_unit_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_unit_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_unit_product.FormattingEnabled = true;
            this.com_unit_product.Location = new System.Drawing.Point(227, 160);
            this.com_unit_product.Name = "com_unit_product";
            this.com_unit_product.Size = new System.Drawing.Size(572, 36);
            this.com_unit_product.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unit";
            // 
            // btn_add_cateory
            // 
            this.btn_add_cateory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_cateory.BackColor = System.Drawing.Color.Navy;
            this.btn_add_cateory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_cateory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_cateory.ForeColor = System.Drawing.Color.White;
            this.btn_add_cateory.Location = new System.Drawing.Point(821, 92);
            this.btn_add_cateory.Name = "btn_add_cateory";
            this.btn_add_cateory.Size = new System.Drawing.Size(170, 36);
            this.btn_add_cateory.TabIndex = 11;
            this.btn_add_cateory.Text = "Add Category";
            this.btn_add_cateory.UseVisualStyleBackColor = false;
            this.btn_add_cateory.Click += new System.EventHandler(this.btn_add_cateory_Click);
            // 
            // btn_add_unit
            // 
            this.btn_add_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_unit.BackColor = System.Drawing.Color.Navy;
            this.btn_add_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_unit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_unit.ForeColor = System.Drawing.Color.White;
            this.btn_add_unit.Location = new System.Drawing.Point(821, 159);
            this.btn_add_unit.Name = "btn_add_unit";
            this.btn_add_unit.Size = new System.Drawing.Size(170, 36);
            this.btn_add_unit.TabIndex = 12;
            this.btn_add_unit.Text = "Add Unit";
            this.btn_add_unit.UseVisualStyleBackColor = false;
            this.btn_add_unit.Click += new System.EventHandler(this.btn_add_unit_Click);
            // 
            // btn_save_new_product
            // 
            this.btn_save_new_product.BackColor = System.Drawing.Color.Green;
            this.btn_save_new_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_new_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_new_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_new_product.ForeColor = System.Drawing.Color.White;
            this.btn_save_new_product.Location = new System.Drawing.Point(234, 3);
            this.btn_save_new_product.Name = "btn_save_new_product";
            this.btn_save_new_product.Size = new System.Drawing.Size(225, 37);
            this.btn_save_new_product.TabIndex = 13;
            this.btn_save_new_product.Text = "Save New Product";
            this.btn_save_new_product.UseVisualStyleBackColor = false;
            // 
            // btn_cancel_product
            // 
            this.btn_cancel_product.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_product.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_product.Location = new System.Drawing.Point(696, 3);
            this.btn_cancel_product.Name = "btn_cancel_product";
            this.btn_cancel_product.Size = new System.Drawing.Size(228, 37);
            this.btn_cancel_product.TabIndex = 14;
            this.btn_cancel_product.Text = "Cancel";
            this.btn_cancel_product.UseVisualStyleBackColor = false;
            this.btn_cancel_product.Click += new System.EventHandler(this.btn_cancel_product_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_add_product, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel_product, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save_new_product, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save_modfiy_product, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 242);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 43);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.FillWeight = 30F;
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.FillWeight = 150F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // CategoryProduct
            // 
            this.CategoryProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryProduct.FillWeight = 150F;
            this.CategoryProduct.HeaderText = "Category";
            this.CategoryProduct.Name = "CategoryProduct";
            // 
            // UnitProduct
            // 
            this.UnitProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitProduct.HeaderText = "Unit";
            this.UnitProduct.Name = "UnitProduct";
            // 
            // btnmodifyproduct
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.btnmodifyproduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnmodifyproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodifyproduct.HeaderText = "";
            this.btnmodifyproduct.Name = "btnmodifyproduct";
            this.btnmodifyproduct.ReadOnly = true;
            this.btnmodifyproduct.Text = "Modfiy";
            this.btnmodifyproduct.UseColumnTextForButtonValue = true;
            // 
            // btndeleteproduct
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.btndeleteproduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.btndeleteproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeleteproduct.HeaderText = "";
            this.btndeleteproduct.Name = "btndeleteproduct";
            this.btndeleteproduct.ReadOnly = true;
            this.btndeleteproduct.Text = "Delete";
            this.btndeleteproduct.UseColumnTextForButtonValue = true;
            // 
            // Products_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_add_unit);
            this.Controls.Add(this.btn_add_cateory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_unit_product);
            this.Controls.Add(this.com_category_product);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchproduct);
            this.Controls.Add(this.DGV_product);
            this.Name = "Products_UC";
            this.Size = new System.Drawing.Size(1011, 646);
            this.Load += new System.EventHandler(this.Products_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_product;
        private System.Windows.Forms.TextBox txt_searchproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_save_modfiy_product;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.ComboBox com_category_product;
        private System.Windows.Forms.ComboBox com_unit_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add_cateory;
        private System.Windows.Forms.Button btn_add_unit;
        private System.Windows.Forms.Button btn_save_new_product;
        private System.Windows.Forms.Button btn_cancel_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitProduct;
        private System.Windows.Forms.DataGridViewButtonColumn btnmodifyproduct;
        private System.Windows.Forms.DataGridViewButtonColumn btndeleteproduct;
    }
}
