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
    public partial class Category : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=QLThueBangDia");
        public Category()
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
            comm.CommandText = "SELECT * FROM get_bangdia_details()";
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

        private void Category_Load(object sender, EventArgs e)
        {
            LoadForm("BangDia", dgvCategory);
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ResizeDgv(dgvCategory);
        }
    }
}
