
namespace QuanLyThueBangDia
{
    partial class DBoard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.butCreateBill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butAddCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.cmsTheLoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butRefresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBangDia = new System.Windows.Forms.DataGridView();
            this.cmsBangDia = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtNameBangDia = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.butResetCart = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.butAddProduct = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cmsCart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStatusBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPayD = new System.Windows.Forms.DateTimePicker();
            this.dtpRentD = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.cmsTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDia)).BeginInit();
            this.cmsBangDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.cmsCart.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.butCreateBill);
            this.panel3.Location = new System.Drawing.Point(85, 712);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 60);
            this.panel3.TabIndex = 28;
            // 
            // butCreateBill
            // 
            this.butCreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateBill.Location = new System.Drawing.Point(469, 4);
            this.butCreateBill.Margin = new System.Windows.Forms.Padding(4);
            this.butCreateBill.Name = "butCreateBill";
            this.butCreateBill.Size = new System.Drawing.Size(167, 43);
            this.butCreateBill.TabIndex = 3;
            this.butCreateBill.Text = "Create Bill";
            this.butCreateBill.UseVisualStyleBackColor = true;
            this.butCreateBill.Click += new System.EventHandler(this.butCreateBill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(513, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 67);
            this.label5.TabIndex = 29;
            this.label5.Text = "MyStore";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.butAddCategory);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.dgvTheLoai);
            this.panel1.Controls.Add(this.butRefresh);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvBangDia);
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtTheloai);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtPID);
            this.panel1.Controls.Add(this.txtNameBangDia);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Location = new System.Drawing.Point(85, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 591);
            this.panel1.TabIndex = 26;
            // 
            // butAddCategory
            // 
            this.butAddCategory.Location = new System.Drawing.Point(415, 548);
            this.butAddCategory.Name = "butAddCategory";
            this.butAddCategory.Size = new System.Drawing.Size(107, 25);
            this.butAddCategory.TabIndex = 13;
            this.butAddCategory.Text = "Add Category";
            this.butAddCategory.UseVisualStyleBackColor = true;
            this.butAddCategory.Click += new System.EventHandler(this.butAddCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(309, 549);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 12;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.ContextMenuStrip = this.cmsTheLoai;
            this.dgvTheLoai.Location = new System.Drawing.Point(4, 391);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.RowHeadersWidth = 51;
            this.dgvTheLoai.RowTemplate.Height = 24;
            this.dgvTheLoai.Size = new System.Drawing.Size(532, 150);
            this.dgvTheLoai.TabIndex = 11;
            this.dgvTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellContentClick);
            // 
            // cmsTheLoai
            // 
            this.cmsTheLoai.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTheLoai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsTheLoai.Name = "cmsTheLoai";
            this.cmsTheLoai.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(29, 547);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(80, 26);
            this.butRefresh.TabIndex = 8;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Price";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 17);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // dgvBangDia
            // 
            this.dgvBangDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDia.ContextMenuStrip = this.cmsBangDia;
            this.dgvBangDia.Location = new System.Drawing.Point(4, 178);
            this.dgvBangDia.Name = "dgvBangDia";
            this.dgvBangDia.RowHeadersWidth = 51;
            this.dgvBangDia.RowTemplate.Height = 24;
            this.dgvBangDia.Size = new System.Drawing.Size(532, 205);
            this.dgvBangDia.TabIndex = 6;
            this.dgvBangDia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDia_CellContentClick);
            // 
            // cmsBangDia
            // 
            this.cmsBangDia.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBangDia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.cmsBangDia.Name = "cmsBangDia";
            this.cmsBangDia.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(415, 79);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(101, 34);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(90, 63);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(258, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(90, 121);
            this.txtTheloai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheloai.Multiline = true;
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(258, 21);
            this.txtTheloai.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(90, 150);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(258, 21);
            this.txtStatus.TabIndex = 1;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(90, 13);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPID.Multiline = true;
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(258, 21);
            this.txtPID.TabIndex = 1;
            // 
            // txtNameBangDia
            // 
            this.txtNameBangDia.Location = new System.Drawing.Point(90, 38);
            this.txtNameBangDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameBangDia.Multiline = true;
            this.txtNameBangDia.Name = "txtNameBangDia";
            this.txtNameBangDia.Size = new System.Drawing.Size(258, 21);
            this.txtNameBangDia.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(90, 92);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(258, 21);
            this.txtQuantity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(145, 4);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomer.Multiline = true;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(256, 29);
            this.txtCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(145, 44);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(256, 29);
            this.txtPhone.TabIndex = 3;
            // 
            // butResetCart
            // 
            this.butResetCart.Location = new System.Drawing.Point(477, 547);
            this.butResetCart.Margin = new System.Windows.Forms.Padding(4);
            this.butResetCart.Name = "butResetCart";
            this.butResetCart.Size = new System.Drawing.Size(101, 34);
            this.butResetCart.TabIndex = 5;
            this.butResetCart.Text = "Reset";
            this.butResetCart.UseVisualStyleBackColor = true;
            this.butResetCart.Click += new System.EventHandler(this.butResetCart_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(55, 511);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(373, 30);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "                         Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(422, 511);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(156, 30);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = " 0";
            // 
            // butAddProduct
            // 
            this.butAddProduct.Location = new System.Drawing.Point(4, 262);
            this.butAddProduct.Name = "butAddProduct";
            this.butAddProduct.Size = new System.Drawing.Size(44, 44);
            this.butAddProduct.TabIndex = 12;
            this.butAddProduct.Text = ">>";
            this.butAddProduct.UseVisualStyleBackColor = true;
            this.butAddProduct.Click += new System.EventHandler(this.butAddProduct_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.ContextMenuStrip = this.cmsCart;
            this.dgvCart.Location = new System.Drawing.Point(55, 178);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(523, 326);
            this.dgvCart.TabIndex = 13;
            // 
            // cmsCart
            // 
            this.cmsCart.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem2});
            this.cmsCart.Name = "cmsCart";
            this.cmsCart.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtStatusBill);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpPayD);
            this.panel2.Controls.Add(this.dtpRentD);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Controls.Add(this.butAddProduct);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.butResetCart);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCustomer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(632, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 591);
            this.panel2.TabIndex = 27;
            // 
            // txtStatusBill
            // 
            this.txtStatusBill.Location = new System.Drawing.Point(145, 143);
            this.txtStatusBill.Name = "txtStatusBill";
            this.txtStatusBill.Size = new System.Drawing.Size(256, 22);
            this.txtStatusBill.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bill Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pay Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rent Day";
            // 
            // dtpPayD
            // 
            this.dtpPayD.CustomFormat = "dd/mm/yyyy";
            this.dtpPayD.Location = new System.Drawing.Point(145, 114);
            this.dtpPayD.Name = "dtpPayD";
            this.dtpPayD.Size = new System.Drawing.Size(256, 22);
            this.dtpPayD.TabIndex = 15;
            // 
            // dtpRentD
            // 
            this.dtpRentD.CustomFormat = "dd/mm/yyyy";
            this.dtpRentD.Location = new System.Drawing.Point(145, 85);
            this.dtpRentD.Name = "dtpRentD";
            this.dtpRentD.Size = new System.Drawing.Size(256, 22);
            this.dtpRentD.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // DBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 817);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DBoard_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.cmsTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDia)).EndInit();
            this.cmsBangDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.cmsCart.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butCreateBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTheloai;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNameBangDia;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.ContextMenuStrip cmsTheLoai;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button butAddCategory;
        private System.Windows.Forms.ContextMenuStrip cmsBangDia;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvBangDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button butResetCart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button butAddProduct;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsCart;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPayD;
        private System.Windows.Forms.DateTimePicker dtpRentD;
        private System.Windows.Forms.TextBox txtStatusBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}

