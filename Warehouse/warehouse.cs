using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class warehouse : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\WarehouseDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter, adapter_cat;
        int Id;
        public warehouse()
        {
            InitializeComponent();
            MainDataBase();
        }
        //Не показывает данные в grid
        public void MainDataBase()
        {
            connect.Open();

            DataTable dt_products = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Products", connect);
            adapter.Fill(dt_products);
            grid.DataSource = dt_products;
            connect.Close();
            CategoryDataBase();

            connect.Close();
        }
        public void CategoryDataBase()
        {
            connect.Open();

            adapter_cat = new SqlDataAdapter("SELECT Name FROM Category", connect);
            DataTable dt_cat = new DataTable();
            adapter_cat.Fill(dt_cat);
            foreach (DataRow name in dt_cat.Rows)
            {
                category_box.Items.Add(name["Name"]);
            }

            connect.Close();
        }

        private void Add_Cat_Click(object sender, EventArgs e)
        {
            if (category_box.Text=="" ||
                category_box.Text == " ")
            {
                MessageBox.Show("Insert text please.");
            }
            else
            {
                connect.Open();

                cmd = new SqlCommand("INSERT INTO Category (Name) VALUES (@cat)", connect);
                cmd.Parameters.AddWithValue("@cat", category_box.Text);
                cmd.ExecuteNonQuery();

                connect.Close();
                CLearBoxes();
                MainDataBase();
                MessageBox.Show("Category was added");
            }
            
        }
        //Имеется ошибка с базой данных, где неправильное занчение Id для Category
        private void Add_Product_Click(object sender, EventArgs e)
        {
            if (product_box.Text.Trim() != string.Empty &&
                quantity_box.Text.Trim() != string.Empty &&
                price_box.Text.Trim() != string.Empty &&
                category_box.SelectedItem != null)
            {
                //try
                //{
                    cmd = new SqlCommand("INSERT INTO Products (Name,Quantity,Price,Category_Id) VALUES (@name,@quantity,@price,@cat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@name", product_box.Text);
                    cmd.Parameters.AddWithValue("@quantity", quantity_box.Value);
                    cmd.Parameters.AddWithValue("@price", price_box.Value);
                    cmd.Parameters.AddWithValue("@cat", category_box.SelectedIndex + 1);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    CLearBoxes();
                    MainDataBase();
                    MessageBox.Show("Product was added");
                //}
                //catch (Exception)
                //{
                    //MessageBox.Show("ERROR:");
                //}
            }
            else
            {
                MessageBox.Show("Write values please.");
            }
        }
        //Не проверено
        private void Update_Product_Click(object sender, EventArgs e)
        {
            if (product_box.Text.Trim() != string.Empty &&
                quantity_box.Text.Trim() != string.Empty &&
                price_box.Text.Trim() != string.Empty)
            {
                cmd = new SqlCommand("UPDATE Products SET Name=@name,Quantity=@quantity,Price=@price WHERE Id=@id", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", product_box.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity_box.Text);
                cmd.Parameters.AddWithValue("@price", price_box.Text.ToString().Replace(",", "."));
                cmd.ExecuteNonQuery();
                connect.Close();
                MainDataBase();
                CLearBoxes();
                MessageBox.Show("Product was updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        //Не проверено
        private void Delete_Product_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                return;

            string sql = "DELETE FROM Products WHERE Id = @rowID";

            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                connect.Open();

                int selectedIndex = grid.SelectedRows[0].Index;
                int rowID = Convert.ToInt32(grid[0, selectedIndex].Value);

                deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                deleteRecord.ExecuteNonQuery();

                grid.Rows.RemoveAt(selectedIndex);

                connect.Close();
            }
        }

        private void Delete_Cat_Click(object sender, EventArgs e)
        {            
            if (category_box.Text == "" ||
                category_box.Text == " ") return;
            connect.Open();
            string sql = "DELETE FROM Category WHERE Name = @cat";
            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                deleteRecord.Parameters.AddWithValue("@cat", category_box.Text);
                deleteRecord.ExecuteNonQuery();
            }
            category_box.SelectedIndex = -1;
            connect.Close();
            CLearBoxes();
            MainDataBase();
        }
        //Не проверено
        private void grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)(grid.Rows[e.RowIndex].Cells[0].Value);
            product_box.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity_box.Text = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            price_box.Text = grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string v = grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            category_box.SelectedIndex = Int32.Parse(v) - 1;
        }

        public void CLearBoxes()
        {
            product_box.Text = "";
            quantity_box.Text = "";
            price_box.Text = "";
            category_box.Items.Clear();
        }

    }
}
