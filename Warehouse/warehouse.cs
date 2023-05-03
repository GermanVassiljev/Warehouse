using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Warehouse
{
    public partial class warehouse : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\source\repos\Warehouse\Warehouse\AppData\WarehouseDB (1).mdf;Integrated Security=True");
        SqlCommand cmd, cmdcheckId, cmdcheckCat_Name, cmdCheck;
        SqlDataAdapter adapter_toode, adapter_kat;
        OpenFileDialog piltValiDialog;
        SaveFileDialog saveValiDialog;
        public warehouse()
        {
            InitializeComponent();
            Naita_Andmed();
        }

        public void Naita_Kategooria()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Cat_Name FROM Category", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                category_box.Items.Add(nimetus["Cat_Name"]);
            }
            connect.Close();
        }

        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Products", connect);
            adapter_toode.Fill(dt_toode);
            grid.DataSource = dt_toode;

            //toodePilt.Image = Image.FromFile("../../images/Info.png");
            //toodePilt.SizeMode = PictureBoxSizeMode.StretchImage;
            connect.Close();
            Naita_Kategooria();
        }

        public void Kustuta_Andmed()
        {
            product_box.Text = "";
            price_box.Text = "";
            quantity_box.Text = "";
            category_box.Items.Clear();
        }

        int IdProduct;
        int IdCategory;

        private void Update_Product_Click(object sender, EventArgs e)
        {
            if (product_box.Text != "" && quantity_box.Text != "" &&
                price_box.Text != "" && pictureBox.Image != null)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Products SET Name=@name,Quantity=@quant,Price=@price,Category_Id=@cat WHERE Id=@id", connect); //,Pilt = @pilt ,Category_Id=@cat
                    connect.Open();
                    cmd.Parameters.AddWithValue("@id", IdProduct);
                    cmd.Parameters.AddWithValue("@name", product_box.Text);
                    cmd.Parameters.AddWithValue("@quant", quantity_box.Value);
                    cmd.Parameters.AddWithValue("@price", price_box.Value.ToString().Replace(",", "."));
                    using (SqlCommand command = new SqlCommand("SELECT Id FROM Category WHERE Cat_Name=@cat", connect))
                    {
                        command.Parameters.AddWithValue("@cat", category_box.Text);

                        string result = Convert.ToString(command.ExecuteScalar());

                        // Добавляет параметр. Вноситься Id, а не стринг из category_box
                        cmd.Parameters.AddWithValue("@cat", int.Parse(result));
                    }
                    //string file_pilt = nimeBox.Text + ".jpg";
                    //cmd.Parameters.AddWithValue("@pilt", file_pilt); 
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_Andmed();
                    Kustuta_Andmed();
                    MessageBox.Show("Values updated");
                }
                catch (Exception)
                {
                    MessageBox.Show("Database error");
                }
            }
            else
            {
                MessageBox.Show("Enter values");
            }
        }

        private void picBtn_Click(object sender, EventArgs e)
        {
            piltValiDialog = new OpenFileDialog();

            piltValiDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            piltValiDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            FileInfo open_info = new FileInfo(@"C:..\..\Downloads\" + piltValiDialog.FileName);
            if (piltValiDialog.ShowDialog() == DialogResult.OK && product_box != null)
            {
                saveValiDialog = new SaveFileDialog();
                saveValiDialog.InitialDirectory = Path.GetFullPath(@"..\..\images");
                saveValiDialog.FileName = product_box.Text + Path.GetExtension(piltValiDialog.FileName); //".jpg";            
                saveValiDialog.Filter = "Image Files" + Path.GetExtension(piltValiDialog.FileName) + "|" + Path.GetExtension(piltValiDialog.FileName);


                if (saveValiDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(piltValiDialog.FileName, saveValiDialog.FileName);
                    saveValiDialog.RestoreDirectory = true;
                    pictureBox.Image = Image.FromFile(saveValiDialog.FileName);
                }
            }
        }

        private void Delete_Product_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                return;

            string sql = "DELETE FROM Products WHERE Id = @rowID";

            using (SqlCommand deletedRecord = new SqlCommand(sql, connect))
            {
                connect.Open();
                int selectedIndex = grid.SelectedRows[0].Index;
                int rowId = Convert.ToInt32(grid[0, selectedIndex].Value);
                deletedRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowId;
                deletedRecord.ExecuteNonQuery();

                grid.Rows.RemoveAt(selectedIndex);
                connect.Close();
            }
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            if (product_box.Text.Trim() != string.Empty && quantity_box.Text.Trim() != string.Empty &&
                price_box.Text.Trim() != string.Empty && category_box.SelectedItem != null) //&& Int32.Parse(hindBox.Text) > 0
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Products (Name,Quantity,Price,Category_Id)" +
                        " VALUES (@name,@quant,@price,@cat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@name", product_box.Text);
                    cmd.Parameters.AddWithValue("@quant", quantity_box.Text);
                    cmd.Parameters.AddWithValue("@price", price_box.Text);
                    cmd.Parameters.AddWithValue("@cat", category_box.SelectedIndex);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_Andmed();
                    Naita_Andmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database error");
                }
            }
            else
            {
                MessageBox.Show("Enter corrrect values");
            }
        }

        private void Delete_Cat_Click(object sender, EventArgs e)
        {
            if (category_box.Text == "")
                return;

            string sql = "DELETE FROM Category WHERE Cat_Name = @name";

            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                connect.Open();
                cmd.Parameters.AddWithValue("@name", category_box.Text);
                cmd.ExecuteNonQuery();
                connect.Close();

                Kustuta_Andmed();
                Naita_Kategooria();
            }
            category_box.Text = string.Empty;
        }

        private void Add_Cat_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("INSERT INTO Category(Cat_Name)" +
                " VALUES (@cat)", connect);
            cmd.Parameters.AddWithValue("@cat", category_box.Text);
            cmd.ExecuteNonQuery();
            connect.Close();

            Kustuta_Andmed();
            Naita_Kategooria();
        }

        private void grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdProduct = (int)grid.Rows[e.RowIndex].Cells[0].Value;
            product_box.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity_box.Text = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            price_box.Text = grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                pictureBox.Image = Image.FromFile(@"..\..\images\" + grid.Rows[e.RowIndex].Cells[4].Value.ToString());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                pictureBox.Image = Image.FromFile(@"..\..\images\Info.png");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                MessageBox.Show("Fail puudub");
            }
            string v = grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            category_box.SelectedIndex = Int32.Parse(v) - 1;
        }
    }
}
