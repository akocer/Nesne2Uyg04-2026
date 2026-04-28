namespace Nesne2Uyg04_2026.Forms
{
    partial class FrmWork
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
            dgWork = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dgCustomer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtPhone = new TextBox();
            label10 = new Label();
            txtName = new TextBox();
            label9 = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label7 = new Label();
            txtPaid = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dtDate = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgWork
            // 
            dgWork.AllowUserToAddRows = false;
            dgWork.AllowUserToDeleteRows = false;
            dgWork.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWork.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn7 });
            dgWork.Location = new Point(508, 58);
            dgWork.Name = "dgWork";
            dgWork.ReadOnly = true;
            dgWork.RowHeadersWidth = 62;
            dgWork.RowTemplate.Height = 33;
            dgWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgWork.Size = new Size(697, 560);
            dgWork.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Kayıt No";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Başlık";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Ücret";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.AllowUserToDeleteRows = false;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5 });
            dgCustomer.Location = new Point(493, 58);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 62;
            dgCustomer.RowTemplate.Height = 33;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(697, 560);
            dgCustomer.TabIndex = 57;
            dgCustomer.DoubleClick += dgCustomer_DoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Müşteri No";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 174);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(300, 31);
            txtPhone.TabIndex = 79;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 180);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 78;
            label10.Text = "Telefon";
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 137);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(300, 31);
            txtName.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 143);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 76;
            label9.Text = "Adı Soyadı";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.HotTrack;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(289, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 39);
            btnSearch.TabIndex = 75;
            btnSearch.Text = "Gözat";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(289, 568);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 50);
            btnClear.TabIndex = 74;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(139, 568);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 50);
            btnSave.TabIndex = 73;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 498);
            label7.Name = "label7";
            label7.Size = new Size(29, 25);
            label7.TabIndex = 72;
            label7.Text = "TL";
            // 
            // txtPaid
            // 
            txtPaid.Location = new Point(139, 492);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(122, 31);
            txtPaid.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 498);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 70;
            label8.Text = "Ödeme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 398);
            label6.Name = "label6";
            label6.Size = new Size(29, 25);
            label6.TabIndex = 69;
            label6.Text = "TL";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(139, 392);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(122, 31);
            txtPrice.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 398);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 67;
            label5.Text = "Ücreti";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(139, 281);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 105);
            txtDescription.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 287);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 65;
            label4.Text = "Açıklama";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(139, 244);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 31);
            txtTitle.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 250);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 63;
            label3.Text = "Başlık";
            // 
            // txtId
            // 
            txtId.Location = new Point(139, 95);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(122, 31);
            txtId.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 61;
            label2.Text = "Müşteri No";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(139, 52);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 31);
            dtDate.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 59;
            label1.Text = "Tarih";
            // 
            // FrmWork
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 704);
            Controls.Add(txtPhone);
            Controls.Add(label10);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(txtPaid);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dtDate);
            Controls.Add(label1);
            Controls.Add(dgWork);
            Controls.Add(dgCustomer);
            Name = "FrmWork";
            Text = "FrmWork";
            Load += FrmWork_Load;
            ((System.ComponentModel.ISupportInitialize)dgWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgWork;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridView dgCustomer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        public TextBox txtPhone;
        private Label label10;
        public TextBox txtName;
        private Label label9;
        private Button btnSearch;
        private Button btnClear;
        private Button btnSave;
        private Label label7;
        private TextBox txtPaid;
        private Label label8;
        private Label label6;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtTitle;
        private Label label3;
        public TextBox txtId;
        private Label label2;
        private DateTimePicker dtDate;
        private Label label1;
    }
}