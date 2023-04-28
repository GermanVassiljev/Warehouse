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
            this.price_box = new System.Windows.Forms.DomainUpDown();
            this.quantity_box = new System.Windows.Forms.DomainUpDown();
            this.Add_Cat = new System.Windows.Forms.Button();
            this.Delete_Cat = new System.Windows.Forms.Button();
            this.Add_Product = new System.Windows.Forms.Button();
            this.Delete_Product = new System.Windows.Forms.Button();
            this.Update_Product = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.warehouseDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDBDataSet = new Warehouse.WarehouseDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // product_box
            // 
            this.product_box.Location = new System.Drawing.Point(173, 30);
            this.product_box.Name = "product_box";
            this.product_box.Size = new System.Drawing.Size(124, 20);
            this.product_box.TabIndex = 4;
            // 
            // category_box
            // 
            this.category_box.FormattingEnabled = true;
            this.category_box.Location = new System.Drawing.Point(173, 149);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(124, 21);
            this.category_box.TabIndex = 5;
            // 
            // price_box
            // 
            this.price_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_box.Location = new System.Drawing.Point(173, 108);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(124, 26);
            this.price_box.TabIndex = 6;
            // 
            // quantity_box
            // 
            this.quantity_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity_box.Location = new System.Drawing.Point(173, 68);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(124, 26);
            this.quantity_box.TabIndex = 7;
            // 
            // Add_Cat
            // 
            this.Add_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Cat.Location = new System.Drawing.Point(303, 145);
            this.Add_Cat.Name = "Add_Cat";
            this.Add_Cat.Size = new System.Drawing.Size(121, 27);
            this.Add_Cat.TabIndex = 8;
            this.Add_Cat.Text = "Add category";
            this.Add_Cat.UseVisualStyleBackColor = true;
            this.Add_Cat.Click += new System.EventHandler(this.Add_Cat_Click);
            // 
            // Delete_Cat
            // 
            this.Delete_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Cat.Location = new System.Drawing.Point(430, 145);
            this.Delete_Cat.Name = "Delete_Cat";
            this.Delete_Cat.Size = new System.Drawing.Size(131, 27);
            this.Delete_Cat.TabIndex = 9;
            this.Delete_Cat.Text = "Delete category";
            this.Delete_Cat.UseVisualStyleBackColor = true;
            this.Delete_Cat.Click += new System.EventHandler(this.Delete_Cat_Click);
            // 
            // Add_Product
            // 
            this.Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Product.Location = new System.Drawing.Point(653, 203);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(135, 27);
            this.Add_Product.TabIndex = 10;
            this.Add_Product.Text = "Add product";
            this.Add_Product.UseVisualStyleBackColor = true;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // Delete_Product
            // 
            this.Delete_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Product.Location = new System.Drawing.Point(653, 246);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(135, 27);
            this.Delete_Product.TabIndex = 11;
            this.Delete_Product.Text = "Delete product";
            this.Delete_Product.UseVisualStyleBackColor = true;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Update_Product
            // 
            this.Update_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_Product.Location = new System.Drawing.Point(653, 289);
            this.Update_Product.Name = "Update_Product";
            this.Update_Product.Size = new System.Drawing.Size(135, 27);
            this.Update_Product.TabIndex = 12;
            this.Update_Product.Text = "Update product";
            this.Update_Product.UseVisualStyleBackColor = true;
            this.Update_Product.Click += new System.EventHandler(this.Update_Product_Click);
            // 
            // grid
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.DataSource = this.warehouseDBDataSetBindingSource;
            this.grid.Location = new System.Drawing.Point(12, 207);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(509, 150);
            this.grid.TabIndex = 13;
            this.grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_RowHeaderMouseClick);
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
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Update_Product);
            this.Controls.Add(this.Delete_Product);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.Delete_Cat);
            this.Controls.Add(this.Add_Cat);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.product_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "warehouse";
            this.Text = "warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSet)).EndInit();
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
        private System.Windows.Forms.DomainUpDown price_box;
        private System.Windows.Forms.DomainUpDown quantity_box;
        private System.Windows.Forms.Button Add_Cat;
        private System.Windows.Forms.Button Delete_Cat;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Button Delete_Product;
        private System.Windows.Forms.Button Update_Product;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource warehouseDBDataSetBindingSource;
        private WarehouseDBDataSet warehouseDBDataSet;
    }
}