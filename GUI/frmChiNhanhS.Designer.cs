namespace QuanLyNganHang
{
    partial class frmChiNhanhS
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
            panel1 = new Panel();
            btnBaoCao = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtDiachi = new TextBox();
            txtTenCN = new TextBox();
            txtSdt = new TextBox();
            txtMaCN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvChinhanh = new DataGridView();
            panel4 = new Panel();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChinhanh).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnBaoCao);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 50);
            panel1.TabIndex = 27;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.Black;
            btnBaoCao.FlatStyle = FlatStyle.Popup;
            btnBaoCao.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCao.ForeColor = Color.Snow;
            btnBaoCao.Location = new Point(876, 10);
            btnBaoCao.Margin = new Padding(3, 4, 3, 4);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(95, 29);
            btnBaoCao.TabIndex = 4;
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(977, 10);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(12, 11);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 1;
            label6.Text = "Phonix bank";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(409, 72);
            label5.Name = "label5";
            label5.Size = new Size(314, 32);
            label5.TabIndex = 22;
            label5.Text = "QUẢN LÝ CHI NHÁNH";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvChinhanh);
            panel2.Location = new Point(12, 148);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 588);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(txtDiachi);
            panel3.Controls.Add(txtTenCN);
            panel3.Controls.Add(txtSdt);
            panel3.Controls.Add(txtMaCN);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(-60, -46);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 346);
            panel3.TabIndex = 32;
            panel3.Paint += panel3_Paint;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(749, 135);
            txtDiachi.Margin = new Padding(3, 4, 3, 4);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(300, 27);
            txtDiachi.TabIndex = 20;
            // 
            // txtTenCN
            // 
            txtTenCN.Location = new Point(223, 131);
            txtTenCN.Margin = new Padding(3, 4, 3, 4);
            txtTenCN.Name = "txtTenCN";
            txtTenCN.Size = new Size(300, 27);
            txtTenCN.TabIndex = 18;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(749, 84);
            txtSdt.Margin = new Padding(3, 4, 3, 4);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(300, 27);
            txtSdt.TabIndex = 19;
            // 
            // txtMaCN
            // 
            txtMaCN.Location = new Point(223, 80);
            txtMaCN.Margin = new Padding(3, 4, 3, 4);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(300, 27);
            txtMaCN.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(620, 88);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 28;
            label4.Text = "Số điện thoại ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(620, 139);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 27;
            label3.Text = "Địa Chỉ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 139);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 26;
            label2.Text = "Tên Chi Nhánh ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 88);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 25;
            label1.Text = "Mã Chi Nhánh ";
            // 
            // dgvChinhanh
            // 
            dgvChinhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChinhanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChinhanh.Dock = DockStyle.Bottom;
            dgvChinhanh.Location = new Point(0, 296);
            dgvChinhanh.Margin = new Padding(3, 4, 3, 4);
            dgvChinhanh.Name = "dgvChinhanh";
            dgvChinhanh.RowHeadersWidth = 51;
            dgvChinhanh.RowTemplate.Height = 24;
            dgvChinhanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChinhanh.Size = new Size(1132, 292);
            dgvChinhanh.TabIndex = 31;
            dgvChinhanh.Click += dgvChinhanh_Click;
            dgvChinhanh.DoubleClick += dgvChinhanh_DoubleClick;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuBar;
            panel4.Controls.Add(btnxoa);
            panel4.Controls.Add(btnsua);
            panel4.Controls.Add(btnthem);
            panel4.Location = new Point(-78, 696);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1339, 142);
            panel4.TabIndex = 30;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(44, 62, 80);
            btnxoa.ForeColor = Color.White;
            btnxoa.Location = new Point(742, 29);
            btnxoa.Margin = new Padding(3, 4, 3, 4);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(130, 62);
            btnxoa.TabIndex = 27;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(44, 62, 80);
            btnsua.ForeColor = Color.White;
            btnsua.Location = new Point(537, 29);
            btnsua.Margin = new Padding(3, 4, 3, 4);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(130, 62);
            btnsua.TabIndex = 26;
            btnsua.Text = "Sửa ";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(44, 62, 80);
            btnthem.ForeColor = Color.White;
            btnthem.Location = new Point(338, 29);
            btnthem.Margin = new Padding(3, 4, 3, 4);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(130, 62);
            btnthem.TabIndex = 25;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // frmChiNhanhS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1086, 816);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmChiNhanhS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Nhánh ";
            FormClosing += ChiNhanh_FormClosing;
            Load += ChiNhanh_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChinhanh).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChinhanh;
        private System.Windows.Forms.Button btnBaoCao;
    }
}