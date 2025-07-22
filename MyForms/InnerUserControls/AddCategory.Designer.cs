namespace InventoryManagement.InnerUserControls
{
    partial class AddCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_category_name = new System.Windows.Forms.TextBox();
            this.DGV_product = new System.Windows.Forms.DataGridView();
            this.btn_save_category = new System.Windows.Forms.Button();
            this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodifycategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndeletecategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_cancel_category = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back_to_product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // txt_category_name
            // 
            this.txt_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_category_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category_name.Location = new System.Drawing.Point(379, 223);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(614, 38);
            this.txt_category_name.TabIndex = 2;
            // 
            // DGV_product
            // 
            this.DGV_product.AllowUserToDeleteRows = false;
            this.DGV_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryname,
            this.btnmodifycategory,
            this.btndeletecategory});
            this.DGV_product.Location = new System.Drawing.Point(18, 355);
            this.DGV_product.MultiSelect = false;
            this.DGV_product.Name = "DGV_product";
            this.DGV_product.RowHeadersVisible = false;
            this.DGV_product.RowTemplate.Height = 24;
            this.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_product.Size = new System.Drawing.Size(975, 277);
            this.DGV_product.TabIndex = 3;
            // 
            // btn_save_category
            // 
            this.btn_save_category.BackColor = System.Drawing.Color.Green;
            this.btn_save_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_category.ForeColor = System.Drawing.Color.White;
            this.btn_save_category.Location = new System.Drawing.Point(3, 3);
            this.btn_save_category.Name = "btn_save_category";
            this.btn_save_category.Size = new System.Drawing.Size(174, 37);
            this.btn_save_category.TabIndex = 4;
            this.btn_save_category.Text = "Save";
            this.btn_save_category.UseVisualStyleBackColor = false;
            // 
            // categoryname
            // 
            this.categoryname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryname.FillWeight = 150F;
            this.categoryname.HeaderText = "Category Name";
            this.categoryname.Name = "categoryname";
            this.categoryname.ReadOnly = true;
            // 
            // btnmodifycategory
            // 
            this.btnmodifycategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.btnmodifycategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnmodifycategory.FillWeight = 50F;
            this.btnmodifycategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodifycategory.HeaderText = "";
            this.btnmodifycategory.Name = "btnmodifycategory";
            this.btnmodifycategory.Text = "Modfiy";
            this.btnmodifycategory.UseColumnTextForButtonValue = true;
            // 
            // btndeletecategory
            // 
            this.btndeletecategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.btndeletecategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.btndeletecategory.FillWeight = 50F;
            this.btndeletecategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletecategory.HeaderText = "";
            this.btndeletecategory.Name = "btndeletecategory";
            this.btndeletecategory.Text = "Delete";
            this.btndeletecategory.UseColumnTextForButtonValue = true;
            // 
            // btn_cancel_category
            // 
            this.btn_cancel_category.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancel_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_category.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_category.Location = new System.Drawing.Point(183, 3);
            this.btn_cancel_category.Name = "btn_cancel_category";
            this.btn_cancel_category.Size = new System.Drawing.Size(175, 37);
            this.btn_cancel_category.TabIndex = 5;
            this.btn_cancel_category.Text = "Cancel";
            this.btn_cancel_category.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_save_category, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel_category, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(505, 282);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 43);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btn_back_to_product
            // 
            this.btn_back_to_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back_to_product.BackColor = System.Drawing.Color.Navy;
            this.btn_back_to_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back_to_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_product.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back_to_product.Location = new System.Drawing.Point(818, 59);
            this.btn_back_to_product.Name = "btn_back_to_product";
            this.btn_back_to_product.Size = new System.Drawing.Size(175, 37);
            this.btn_back_to_product.TabIndex = 17;
            this.btn_back_to_product.Text = "Back";
            this.btn_back_to_product.UseVisualStyleBackColor = false;
            this.btn_back_to_product.Click += new System.EventHandler(this.btn_back_to_product_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back_to_product);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DGV_product);
            this.Controls.Add(this.txt_category_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Size = new System.Drawing.Size(1011, 646);
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_category_name;
        private System.Windows.Forms.DataGridView DGV_product;
        private System.Windows.Forms.Button btn_save_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
        private System.Windows.Forms.DataGridViewButtonColumn btnmodifycategory;
        private System.Windows.Forms.DataGridViewButtonColumn btndeletecategory;
        private System.Windows.Forms.Button btn_cancel_category;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_back_to_product;
    }
}
