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
    public partial class DetailCustomer : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=QLThueBangDia");
        public DetailCustomer(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        #region
        private int id;
        private void LoadFormDetails(string db, DataGridView dgv)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from get_chitietphieuthue (" + id + ")";
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

        private void DetailCustomer_Load(object sender, EventArgs e)
        {
            LoadFormDetails("ChiTietPhieuThue", dgvDetailCustomer);
            dgvDetailCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ResizeDgv(dgvDetailCustomer);
        }
    }
}
