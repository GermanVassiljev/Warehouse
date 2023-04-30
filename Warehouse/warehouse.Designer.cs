namespace Warehouse
{
    partial class warehouse
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_box = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.Add_Cat = new System.Windows.Forms.Button();
            this.Delete_Cat = new System.Windows.Forms.Button();
            this.Add_Product = new System.Windows.Forms.Button();
            this.Delete_Product = new System.Windows.Forms.Button();
            this.Update_Product = new System.Windows.Forms.Button();
            this.warehouseDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDBDataSet = new Warehouse.WarehouseDBDataSet();
            this.quantity_box = new System.Windows.Forms.NumericUpDown();
            this.price_box = new System.Windows.Forms.NumericUpDown();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // product_box
            // 
            this.product_box.Location = new System.Drawing.Point(260, 46);
            this.product_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.product_box.Name = "product_box";
            this.product_box.Size = new System.Drawing.Size(184, 26);
            this.product_box.TabIndex = 4;
            // 
            // category_box
            // 
            this.category_box.FormattingEnabled = true;
            this.category_box.Location = new System.Drawing.Point(260, 229);
            this.category_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(184, 28);
            this.category_box.TabIndex = 5;
            // 
            // Add_Cat
            // 
            this.Add_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Cat.Location = new System.Drawing.Point(454, 223);
            this.Add_Cat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Cat.Name = "Add_Cat";
            this.Add_Cat.Size = new System.Drawing.Size(182, 42);
            this.Add_Cat.TabIndex = 8;
            this.Add_Cat.Text = "Add category";
            this.Add_Cat.UseVisualStyleBackColor = true;
            this.Add_Cat.Click += new System.EventHandler(this.Add_Cat_Click);
            // 
            // Delete_Cat
            // 
            this.Delete_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Cat.Location = new System.Drawing.Point(645, 223);
            this.Delete_Cat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_Cat.Name = "Delete_Cat";
            this.Delete_Cat.Size = new System.Drawing.Size(196, 42);
            this.Delete_Cat.TabIndex = 9;
            this.Delete_Cat.Text = "Delete category";
            this.Delete_Cat.UseVisualStyleBackColor = true;
            this.Delete_Cat.Click += new System.EventHandler(this.Delete_Cat_Click);
            // 
            // Add_Product
            // 
            this.Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Product.Location = new System.Drawing.Point(980, 312);
            this.Add_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(202, 42);
            this.Add_Product.TabIndex = 10;
            this.Add_Product.Text = "Add product";
            this.Add_Product.UseVisualStyleBackColor = true;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // Delete_Product
            // 
            this.Delete_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Product.Location = new System.Drawing.Point(980, 378);
            this.Delete_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(202, 42);
            this.Delete_Product.TabIndex = 11;
            this.Delete_Product.Text = "Delete product";
            this.Delete_Product.UseVisualStyleBackColor = true;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Update_Product
            // 
            this.Update_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_Product.Location = new System.Drawing.Point(980, 445);
            this.Update_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Product.Name = "Update_Product";
            this.Update_Product.Size = new System.Drawing.Size(202, 42);
            this.Update_Product.TabIndex = 12;
            this.Update_Product.Text = "Update product";
            this.Update_Product.UseVisualStyleBackColor = true;
            this.Update_Product.Click += new System.EventHandler(this.Update_Product_Click);
            // 
            // warehouseDBDataSetBindingSource
            // 
            this.warehouseDBDataSetBindingSource.DataSource = this.warehouseDBDataSet;
            this.warehouseDBDataSetBindingSource.Position = 0;
            // 
            // warehouseDBDataSet
            // 
            this.warehouseDBDataSet.DataSetName = "WarehouseDBDataSet";
            this.warehouseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(260, 112);
            this.quantity_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(186, 26);
            this.quantity_box.TabIndex = 14;
            this.quantity_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // price_box
            // 
            this.price_box.DecimalPlaces = 2;
            this.price_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.price_box.Location = new System.Drawing.Point(260, 169);
            this.price_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(186, 26);
            this.price_box.TabIndex = 15;
            this.price_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(13, 312);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 62;
            this.grid.Size = new System.Drawing.Size(930, 334);
            this.grid.TabIndex = 16;
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.Update_Product);
            this.Controls.Add(this.Delete_Product);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.Delete_Cat);
            this.Controls.Add(this.Add_Cat);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.product_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "warehouse";
            this.Text = "warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox product_box;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.Button Add_Cat;
        private System.Windows.Forms.Button Delete_Cat;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Button Delete_Product;
        private System.Windows.Forms.Button Update_Product;
        private System.Windows.Forms.BindingSource warehouseDBDataSetBindingSource;
        private WarehouseDBDataSet warehouseDBDataSet;
        private System.Windows.Forms.NumericUpDown quantity_box;
        private System.Windows.Forms.NumericUpDown price_box;
        private System.Windows.Forms.DataGridView grid;
    }
}