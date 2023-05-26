using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace QuanLyThueBangDia
{
    public partial class DBoard : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=QLThueBangDia");
        public DBoard()
        {
            InitializeComponent();
        }

        #region
        private void LoadForm(string db, DataGridView dgv)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from " + db;
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }
        #endregion
        private void DBoard_Load(object sender, EventArgs e)
        {
            LoadForm("BangDia", dgvBangDia);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBangDia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg = dgvBangDia;
            txtNameBangDia.Text = Convert.ToString(dtg.CurrentRow.Cells[1].Value);
            txtPrice.Text = Convert.ToString(dtg.CurrentRow.Cells[3].Value);
            txtQuantity.Text = Convert.ToString(dtg.CurrentRow.Cells[4].Value);
            txtStatus.Text = Convert.ToString(dtg.CurrentRow.Cells[5].Value);
            txtTheloai.Text = Convert.ToString(dtg.CurrentRow.Cells[2].Value);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //Get info
            string name = txtNameBangDia.Text;
            int categoryID = int.Parse(txtTheloai.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string status = txtStatus.Text;

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL add_product(@name, @categoryID, @price, @quantity, @status)";

            //Insert
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@categoryID", categoryID);
            comm.Parameters.AddWithValue("@price", price);
            comm.Parameters.AddWithValue("@quantity", quantity);
            comm.Parameters.AddWithValue("@status", status);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            LoadForm("BangDia", dgvBangDia);
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}