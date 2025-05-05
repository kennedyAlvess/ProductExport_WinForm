namespace ProductExport.Forms
{
    partial class HomeForms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gw_products = new DataGridView();
            productBindingSource = new BindingSource(components);
            appDbContextBindingSource = new BindingSource(components);
            gw_Product = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gw_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gw_products
            // 
            gw_products.AllowUserToAddRows = false;
            gw_products.AllowUserToDeleteRows = false;
            gw_products.AllowUserToOrderColumns = true;
            gw_products.AllowUserToResizeColumns = false;
            gw_products.AllowUserToResizeRows = false;
            gw_products.AutoGenerateColumns = false;
            gw_products.BackgroundColor = SystemColors.ControlLightLight;
            gw_products.ColumnHeadersHeight = 30;
            gw_products.Columns.AddRange(new DataGridViewColumn[] { gw_Product, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn });
            gw_products.DataSource = productBindingSource;
            gw_products.GridColor = SystemColors.WindowText;
            gw_products.Location = new Point(144, 27);
            gw_products.Name = "gw_products";
            gw_products.ReadOnly = true;
            gw_products.RowHeadersVisible = false;
            gw_products.Size = new Size(483, 430);
            gw_products.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Infrastructure.Entities.Product);
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(Infrastructure.AppDbContext);
            // 
            // gw_Product
            // 
            gw_Product.DataPropertyName = "Name";
            gw_Product.HeaderText = "Produto";
            gw_Product.MinimumWidth = 100;
            gw_Product.Name = "gw_Product";
            gw_Product.ReadOnly = true;
            gw_Product.Resizable = DataGridViewTriState.True;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Valor";
            priceDataGridViewTextBoxColumn.MinimumWidth = 80;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Estoque";
            stockDataGridViewTextBoxColumn.MinimumWidth = 80;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            stockDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            stockDataGridViewTextBoxColumn.Width = 80;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "Data de cadastro";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            createdAtDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            createdAtDataGridViewTextBoxColumn.Width = 120;
            // 
            // HomeForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(811, 497);
            Controls.Add(gw_products);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeForms";
            Text = "HomeForms";
            WindowState = FormWindowState.Maximized;
            Load += HomeForms_Load;
            ((System.ComponentModel.ISupportInitialize)gw_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gw_products;
        private BindingSource productBindingSource;
        private BindingSource appDbContextBindingSource;
        private DataGridViewTextBoxColumn gw_Product;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
    }
}