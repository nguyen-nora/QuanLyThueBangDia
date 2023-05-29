
namespace QuanLyThueBangDia
{
    partial class DetailCustomer
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
            this.dgvDetailCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailCustomer
            // 
            this.dgvDetailCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvDetailCustomer.Name = "dgvDetailCustomer";
            this.dgvDetailCustomer.RowHeadersWidth = 51;
            this.dgvDetailCustomer.RowTemplate.Height = 24;
            this.dgvDetailCustomer.Size = new System.Drawing.Size(1013, 571);
            this.dgvDetailCustomer.TabIndex = 0;
            // 
            // DetailCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 595);
            this.Controls.Add(this.dgvDetailCustomer);
            this.Name = "DetailCustomer";
            this.Text = "DetailCustomer";
            this.Load += new System.EventHandler(this.DetailCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailCustomer;
    }
}