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
        string connectPath = System.Environment.CurrentDirectory+ "\\AppData\\WarehouseDB_1.mdf";
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\WarehouseDB_1.mdf;Integrated Security=True");
        SqlCommand cmd, cmdcheckId, cmdcheckCat_Name, cmdCheck;
        SqlDataAdapter adapter_toode, adapter_kat;
        OpenFileDialog piltValiDialog;
        SaveFileDialog saveValiDialog;
        public warehouse()
        {
            InitializeComponent();
            Naita_Andmed();
        }
        int i = 1; // ©Kevin
        public void Naita_Kategooria()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Cat_Name FROM Category", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            if (i > 0) // ©Kevin
            {
                foreach (DataRow nimetus in dt_kat.Rows)
                {
                    category_box.Items.Add(nimetus["Cat_Name"]);
                    comboBox1.Items.Add(nimetus["Cat_Name"]);
                }
                i -= 2; // ©Kevin
            }
            connect.Close();
        }

        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Name,Quantity,Price, t2.Cat_Name, Picture FROM Products t1 INNER JOIN Category t2 ON t1.Category_Id = t2.Id", connect);
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
            category_box.Text = ""; // ©Kevin
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
                    cmd.Parameters.AddWithValue("@cat", category_box.SelectedIndex + 1);
                    category_boxError = category_box.Text; // ©Kevin
                    //using (SqlCommand command = new SqlCommand("SELECT Id FROM Category WHERE Cat_Name=@cat2", connect))
                    //{
                    //    command.Parameters.AddWithValue("@cat2", category_box.Text);

                    //    string result = Convert.ToString(command.ExecuteScalar()); 

                    //    // Добавляет параметр. Вноситься Id, а не стринг из category_box
                    //    cmd.Parameters.AddWithValue("@cat1", int.Parse(result));
                    //}
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

                cmd = new SqlCommand("UPDATE Products SET Picture=@pic WHERE Id=@id", connect); //,Pilt = @pilt ,Category_Id=@cat
                connect.Open();
                cmd.Parameters.AddWithValue("@id", IdProduct);
                cmd.Parameters.AddWithValue("@pic", saveValiDialog.FileName);
                cmd.ExecuteNonQuery();
                connect.Close();
                Naita_Andmed();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            if (product_box.Text.Trim() != string.Empty && quantity_box.Text.Trim() != string.Empty &&
                price_box.Text.Trim() != string.Empty && category_box.SelectedItem != null) //&& Int32.Parse(hindBox.Text) > 0
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Products (Name,Quantity,Price,Picture,Category_Id)" +
                        " VALUES (@name,@quant,@price,@picture,@cat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@name", product_box.Text);
                    cmd.Parameters.AddWithValue("@quant", quantity_box.Text);
                    cmd.Parameters.AddWithValue("@price", price_box.Value.ToString().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@picture", product_box.Text+".png");
                    cmd.Parameters.AddWithValue("@cat", category_box.SelectedIndex + 1);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\AppData\WarehouseDB_1.mdf; Integrated Security = True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name,Quantity,Price, t2.Cat_Name, Picture FROM Products t1 INNER JOIN Category t2 ON t1.Category_Id = t2.Id WHERE Cat_Name = @SearchTerm";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", comboBox1.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        grid.DataSource = dataTable; // Assuming dataGridView1 is a DataGridView control
                    }
                }
            }
        } // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin // ©Kevin

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
        string category_boxError = ""; // ©Kevin
        private void grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            product_box.Text = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            quantity_box.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            price_box.Text = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            category_box.Text = grid.Rows[e.RowIndex].Cells[3].Value.ToString();
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
        }
    }
}
