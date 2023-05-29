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
    public partial class Customer : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=QLThueBangDia");
        public Customer()
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
        private void ResizeDgv(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadForm("PhieuThue", dgvPhieuThue);
            dgvPhieuThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ResizeDgv(dgvPhieuThue);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm("PhieuThue", dgvPhieuThue);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            string pt_name = "";
            string pt_phone = "";
            DateTime traded = DateTime.Today;
            DateTime payd = DateTime.Today;
            decimal total = 0;
            string statuspt = "";

            //Get info
            if (dgvPhieuThue.SelectedCells.Count > 0)
            {
                int i = dgvPhieuThue.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPhieuThue.Rows[i];
                id = int.Parse(selectedRow.Cells["phieuthueid"].Value.ToString());
                pt_name = selectedRow.Cells["name"].Value.ToString();
                pt_phone = selectedRow.Cells["phone"].Value.ToString();
                traded = DateTime.Parse(selectedRow.Cells["traded"].Value.ToString());
                payd = DateTime.Parse(selectedRow.Cells["payd"].Value.ToString());
                total = decimal.Parse(selectedRow.Cells["total"].Value.ToString());
                statuspt = selectedRow.Cells["statuspt"].Value.ToString();
            }
            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL update_phieuthue(@id, @name, @phone, @traded, @payd, @total, @statuspt)";

            //Insert
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@name", pt_name);
            comm.Parameters.AddWithValue("@phone", pt_phone);
            comm.Parameters.AddWithValue("@traded", traded);
            comm.Parameters.AddWithValue("@payd", payd);
            comm.Parameters.AddWithValue("@total", total);
            comm.Parameters.AddWithValue("@statuspt", statuspt);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Customer update successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            //Get info
            if (dgvPhieuThue.SelectedCells.Count > 0)
            {
                int i = dgvPhieuThue.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPhieuThue.Rows[i];
                id = int.Parse(selectedRow.Cells["phieuthueid"].Value.ToString());
            }

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL delete_phieuthue(@id)";

            //Insert
            comm.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Customer delete successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThue.SelectedCells.Count > 0)
            {
                int i = dgvPhieuThue.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPhieuThue.Rows[i];
                int id = int.Parse(selectedRow.Cells["phieuthueid"].Value.ToString());
                DetailCustomer detailCustomer = new DetailCustomer(id);
                detailCustomer.Show();
            }
        }
    }
}
