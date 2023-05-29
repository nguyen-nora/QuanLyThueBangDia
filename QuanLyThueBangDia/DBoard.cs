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

        private void LoadFormT(DataGridView dgv)
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

        private int ConvertIDtoName(string name)
        {
            string searchValue = name;
            int id = 0;

            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvTheLoai.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        id = int.Parse(row.Cells[0].Value.ToString());
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return id;
        }
        private void ResizeDgv(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private int getCustomerID(string name, string phone, DateTime dt)
        {
            int phieuthueid = 0;
            conn.Open();
            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select get_phieuthueid(@name, @phone, @traded)";

            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@phone", phone);
            comm.Parameters.AddWithValue("@traded", dt);
            // Execute the command.
            NpgsqlDataReader reader = comm.ExecuteReader();
            // Get the PhieuThueID.
            if (reader.Read())
            {
                phieuthueid = int.Parse(reader["get_phieuthueid"].ToString());
                return phieuthueid;
            }
            else return 0;

            // Close the reader.
            reader.Close();

            // Close the connection.
            comm.Dispose();
            conn.Close();
        }

        private void AddCTPhieuThue(int i, int id, int d)
        {
            //Get info
            int BangDiaID = int.Parse(dgvCart.Rows[i].Cells["ID"].Value.ToString());

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Call add_ChiTietPhieuThue(@phieuthueid, @bangdiaid, @soluong)";

            //Add value
            comm.Parameters.AddWithValue("@phieuthueid", id);
            comm.Parameters.AddWithValue("@bangdiaid", BangDiaID);
            comm.Parameters.AddWithValue("@soluong", d);
            
            //
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                comm.ExecuteNonQuery();
                MessageBox.Show("Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comm.Dispose();
            conn.Close();
        }
        #endregion
        private void DBoard_Load(object sender, EventArgs e)
        {
            // Load form
            LoadFormT(dgvBangDia);
            LoadForm("TheLoai", dgvTheLoai);
            // Setup datagridview
            dgvBangDia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ResizeDgv(dgvTheLoai);
            // Custom day
            dtpPayD.Format = DateTimePickerFormat.Custom;
            dtpPayD.CustomFormat = "dd/MM/yyyy";
            dtpRentD.Format = DateTimePickerFormat.Custom;
            dtpRentD.CustomFormat = "dd/MM/yyyy";
        }

        private void dgvBangDia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg = dgvBangDia;
            txtPID.Text = Convert.ToString(dtg.CurrentRow.Cells[0].Value);
            txtNameBangDia.Text = Convert.ToString(dtg.CurrentRow.Cells[1].Value);
            txtPrice.Text = Convert.ToString(dtg.CurrentRow.Cells[3].Value);
            txtQuantity.Text = Convert.ToString(dtg.CurrentRow.Cells[4].Value);
            txtStatus.Text = Convert.ToString(dtg.CurrentRow.Cells[5].Value);
            txtTheloai.Text = Convert.ToString(dtg.CurrentRow.Cells[2].Value);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //Get info
            int id = int.Parse(txtPID.Text);
            string name = txtNameBangDia.Text;
            int categoryID = ConvertIDtoName(txtTheloai.Text);
            decimal price = decimal.Parse(txtPrice.Text.ToString());
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
            LoadFormT(dgvBangDia);
            LoadForm("TheLoai", dgvTheLoai);
        }
        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = 0;
            string name = "";
            int categoryID = 0;
            decimal price = 0;
            int quantity = 0;
            string status = "";
            
            //Get info
            if (dgvBangDia.SelectedCells.Count > 0)
            {
                int i = dgvBangDia.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvBangDia.Rows[i];
                id = int.Parse(selectedRow.Cells["BangDiaID"].Value.ToString());
                name = selectedRow.Cells["name"].Value.ToString();
                categoryID = ConvertIDtoName(selectedRow.Cells["n_theloai"].Value.ToString());
                price = decimal.Parse(selectedRow.Cells["price"].Value.ToString());
                quantity = int.Parse(selectedRow.Cells["quantity"].Value.ToString());
                status = selectedRow.Cells["Status"].Value.ToString();
            }

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL update_product(@id, @name, @categoryID, @price, @quantity, @status)";

            //Insert
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@categoryID", categoryID);
            comm.Parameters.AddWithValue("@price", price);
            comm.Parameters.AddWithValue("@quantity", quantity);
            comm.Parameters.AddWithValue("@status", status);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Product update successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = 0;
            //Get info
            if (dgvBangDia.SelectedCells.Count > 0)
            {
                int i = dgvBangDia.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvBangDia.Rows[i];
                id = int.Parse(selectedRow.Cells["BangDiaID"].Value.ToString());
            }

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL delete_product(@id)";

            //Insert
            comm.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Product delete successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            string name = "";
            //Get info
            if (dgvTheLoai.SelectedCells.Count > 0)
            {
                int i = dgvTheLoai.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTheLoai.Rows[i];
                id = int.Parse(selectedRow.Cells["TheLoaiID"].Value.ToString());
                name = selectedRow.Cells[1].Value.ToString();
            }

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL update_category(@id, @name)";

            //Insert
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@name", name);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Category update successfully.");
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
            if (dgvTheLoai.SelectedCells.Count > 0)
            {
                int i = dgvTheLoai.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTheLoai.Rows[i];
                id = int.Parse(selectedRow.Cells["TheLoaiID"].Value.ToString());
            }

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL delete_product(@id)";

            //Insert
            comm.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Product delete successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }

        private void butAddCategory_Click(object sender, EventArgs e)
        {
            //Get info
            string name = txtCategory.Text;

            //Connection SQL
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL add_category(@name)";

            //Insert
            comm.Parameters.AddWithValue("@name", name);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comm.Dispose();
            conn.Close();
        }
        decimal total = 0;
        private void butAddProduct_Click(object sender, EventArgs e)
        {
            int id = 0;
            string name = "";
            decimal price = 0;
            if (dgvBangDia.SelectedCells.Count > 0)
            {
                int i = dgvBangDia.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvBangDia.Rows[i];
                id = int.Parse(selectedRow.Cells["BangDiaID"].Value.ToString());
                name = selectedRow.Cells["name"].Value.ToString();
                price = decimal.Parse(selectedRow.Cells["price"].Value.ToString());
                total += decimal.Parse(selectedRow.Cells["price"].Value.ToString());
            }
            if (dgvCart.ColumnCount == 0)
            {
                // Create DataGridView by a column count.
                dgvCart.ColumnCount = 3;
                // Set the column header names.
                dgvCart.Columns[0].Name = "ID";
                dgvCart.Columns[1].Name = "Name";
                dgvCart.Columns[2].Name = "Price";
            }
            dgvCart.Rows.Add(new object[] { id, name, price });
            txtTotal.Text = total.ToString();
            ResizeDgv(dgvCart);
        }

        private void butResetCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            txtTotal.Text = "0";
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedCells.Count > 0)
            {
                int i = dgvCart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCart.Rows[i];
                total -= decimal.Parse(selectedRow.Cells["price"].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvCart.SelectedRows)
            {
                dgvCart.Rows.RemoveAt(row.Index);
            }
            txtTotal.Text = total.ToString();
        }
        private void butCreateBill_Click(object sender, EventArgs e)
        {
            //Get info PhieuThue
            string customer = txtCustomer.Text;
            string phone = txtPhone.Text;
            DateTime RentD = dtpRentD.Value;
            DateTime PayD = dtpPayD.Value;
            string statusBill = txtStatusBill.Text;

            //Connection SQL PhieuThue
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL add_customer(@customer, @phone, @rent, @pay, @total, @status)";

            //Insert Phieu Thue
            comm.Parameters.AddWithValue("@customer", customer);
            comm.Parameters.AddWithValue("@phone", phone);
            comm.Parameters.AddWithValue("@rent", RentD);
            comm.Parameters.AddWithValue("@pay", PayD);
            comm.Parameters.AddWithValue("@total", total);
            comm.Parameters.AddWithValue("@status", statusBill);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comm.Dispose();
            conn.Close();

            //Get CustomerID
            int id = getCustomerID(customer, phone, RentD);
            conn.Close();

            //Add ChiTietPhieuThue
            if (id > 0)
            {
                int d = 1;
                this.dgvCart.Sort(this.dgvCart.Columns["ID"], ListSortDirection.Ascending);
                for (int i = 0; i < dgvCart.RowCount - 2; i++)
                {
                    int j = i + 1;
                    if (int.Parse(dgvCart.Rows[i].Cells[0].Value.ToString()) == int.Parse(dgvCart.Rows[j].Cells[0].Value.ToString()))
                    {
                        d++;
                        //MessageBox.Show(dgvCart.Rows[i].Cells[0].Value.ToString());
                        //MessageBox.Show(dgvCart.Rows[j].Cells[0].Value.ToString());
                    }
                    else
                    {
                        AddCTPhieuThue(i, id, d);
                        conn.Close();
                        d = 1;
                    }
                }
                if (dgvCart.RowCount != 0)
                {
                    int i = dgvCart.RowCount - 2;
                    AddCTPhieuThue(i, id, d);
                    conn.Close();
                }
                MessageBox.Show("Create Bill Successfully!");
            } else MessageBox.Show("Create Bill Fail!");
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the form.
            Customer cus = new Customer();

            // Show the form.
            cus.Show();

        }
    }
}