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
            this.quantity_box = new System.Windows.Forms.NumericUpDown();
            this.price_box = new System.Windows.Forms.NumericUpDown();
            this.grid = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.picBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // product_box
            // 
            this.product_box.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_box.Location = new System.Drawing.Point(173, 30);
            this.product_box.Name = "product_box";
            this.product_box.Size = new System.Drawing.Size(124, 26);
            this.product_box.TabIndex = 4;
            // 
            // category_box
            // 
            this.category_box.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_box.FormattingEnabled = true;
            this.category_box.Location = new System.Drawing.Point(173, 149);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(124, 24);
            this.category_box.TabIndex = 5;
            // 
            // Add_Cat
            // 
            this.Add_Cat.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Cat.Location = new System.Drawing.Point(313, 36);
            this.Add_Cat.Name = "Add_Cat";
            this.Add_Cat.Size = new System.Drawing.Size(121, 63);
            this.Add_Cat.TabIndex = 8;
            this.Add_Cat.Text = "Add category";
            this.Add_Cat.UseVisualStyleBackColor = true;
            this.Add_Cat.Click += new System.EventHandler(this.Add_Cat_Click);
            // 
            // Delete_Cat
            // 
            this.Delete_Cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete_Cat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Cat.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Cat.Location = new System.Drawing.Point(313, 110);
            this.Delete_Cat.Name = "Delete_Cat";
            this.Delete_Cat.Size = new System.Drawing.Size(121, 63);
            this.Delete_Cat.TabIndex = 9;
            this.Delete_Cat.Text = "Delete category";
            this.Delete_Cat.UseVisualStyleBackColor = false;
            this.Delete_Cat.Click += new System.EventHandler(this.Delete_Cat_Click);
            // 
            // Add_Product
            // 
            this.Add_Product.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product.Location = new System.Drawing.Point(644, 281);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(125, 28);
            this.Add_Product.TabIndex = 10;
            this.Add_Product.Text = "Add product";
            this.Add_Product.UseVisualStyleBackColor = true;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // Delete_Product
            // 
            this.Delete_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Product.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Product.Location = new System.Drawing.Point(644, 315);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(125, 44);
            this.Delete_Product.TabIndex = 11;
            this.Delete_Product.Text = "Delete product";
            this.Delete_Product.UseVisualStyleBackColor = false;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Update_Product
            // 
            this.Update_Product.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Product.Location = new System.Drawing.Point(644, 365);
            this.Update_Product.Name = "Update_Product";
            this.Update_Product.Size = new System.Drawing.Size(125, 42);
            this.Update_Product.TabIndex = 12;
            this.Update_Product.Text = "Update product";
            this.Update_Product.UseVisualStyleBackColor = true;
            this.Update_Product.Click += new System.EventHandler(this.Update_Product_Click);
            // 
            // quantity_box
            // 
            this.quantity_box.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_box.Location = new System.Drawing.Point(173, 73);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(124, 26);
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
            this.price_box.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.price_box.Location = new System.Drawing.Point(173, 110);
            this.price_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(124, 26);
            this.price_box.TabIndex = 15;
            this.price_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(9, 203);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 62;
            this.grid.Size = new System.Drawing.Size(620, 217);
            this.grid.TabIndex = 16;
            this.grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_RowHeaderMouseClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(562, 11);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(207, 182);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // picBtn
            // 
            this.picBtn.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picBtn.Location = new System.Drawing.Point(644, 203);
            this.picBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBtn.Name = "picBtn";
            this.picBtn.Size = new System.Drawing.Size(125, 63);
            this.picBtn.TabIndex = 18;
            this.picBtn.Text = "Select picture";
            this.picBtn.UseVisualStyleBackColor = true;
            this.picBtn.Click += new System.EventHandler(this.picBtn_Click);
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBtn);
            this.Controls.Add(this.pictureBox);
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
            this.Name = "warehouse";
            this.Text = "warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.NumericUpDown quantity_box;
        private System.Windows.Forms.NumericUpDown price_box;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button picBtn;
    }
}