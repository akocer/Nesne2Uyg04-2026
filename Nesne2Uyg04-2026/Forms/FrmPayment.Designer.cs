namespace Nesne2Uyg04_2026.Forms
{
    partial class FrmPayment
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
            dgPayment = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dtDate = new DateTimePicker();
            label1 = new Label();
            btnSave = new Button();
            label7 = new Label();
            txtPaid = new TextBox();
            label8 = new Label();
            label2 = new Label();
            lbWork = new Label();
            lbPayment = new Label();
            label4 = new Label();
            lbDiff = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            SuspendLayout();
            // 
            // dgWork
            // 
            dgWork.AllowUserToAddRows = false;
            dgWork.AllowUserToDeleteRows = false;
            dgWork.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWork.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn7 });
            dgWork.Location = new Point(724, 39);
            dgWork.Name = "dgWork";
            dgWork.ReadOnly = true;
            dgWork.RowHeadersWidth = 62;
            dgWork.RowTemplate.Height = 33;
            dgWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgWork.Size = new Size(697, 242);
            dgWork.TabIndex = 60;
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
            dgCustomer.Location = new Point(12, 39);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 62;
            dgCustomer.RowTemplate.Height = 33;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(697, 544);
            dgCustomer.TabIndex = 59;
            dgCustomer.Click += dgCustomer_Click;
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
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.AllowUserToDeleteRows = false;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn11 });
            dgPayment.Location = new Point(724, 287);
            dgPayment.Name = "dgPayment";
            dgPayment.ReadOnly = true;
            dgPayment.RowHeadersWidth = 62;
            dgPayment.RowTemplate.Height = 33;
            dgPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPayment.Size = new Size(697, 296);
            dgPayment.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Ödeme No";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Tarih";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Ödenen";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(1121, 589);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 31);
            dtDate.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1009, 595);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 76;
            label1.Text = "Tarih";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(1296, 629);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 41);
            btnSave.TabIndex = 81;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1261, 635);
            label7.Name = "label7";
            label7.Size = new Size(29, 25);
            label7.TabIndex = 80;
            label7.Text = "TL";
            // 
            // txtPaid
            // 
            txtPaid.Location = new Point(1121, 629);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(122, 31);
            txtPaid.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1015, 635);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 78;
            label8.Text = "Ödeme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 609);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 82;
            label2.Text = "İş Toplam : ";
            // 
            // lbWork
            // 
            lbWork.AutoSize = true;
            lbWork.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbWork.Location = new Point(181, 609);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(65, 38);
            lbWork.TabIndex = 82;
            lbWork.Text = "500";
            // 
            // lbPayment
            // 
            lbPayment.AutoSize = true;
            lbPayment.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbPayment.Location = new Point(566, 609);
            lbPayment.Name = "lbPayment";
            lbPayment.Size = new Size(65, 38);
            lbPayment.TabIndex = 83;
            lbPayment.Text = "500";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(331, 609);
            label4.Name = "label4";
            label4.Size = new Size(239, 38);
            label4.TabIndex = 84;
            label4.Text = "Ödeme Toplam : ";
            // 
            // lbDiff
            // 
            lbDiff.AutoSize = true;
            lbDiff.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbDiff.Location = new Point(769, 609);
            lbDiff.Name = "lbDiff";
            lbDiff.Size = new Size(65, 38);
            lbDiff.TabIndex = 85;
            lbDiff.Text = "500";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(666, 609);
            label5.Name = "label5";
            label5.Size = new Size(97, 38);
            label5.TabIndex = 86;
            label5.Text = "Fark : ";
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 679);
            Controls.Add(lbDiff);
            Controls.Add(label5);
            Controls.Add(lbPayment);
            Controls.Add(label4);
            Controls.Add(lbWork);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(txtPaid);
            Controls.Add(label8);
            Controls.Add(dtDate);
            Controls.Add(label1);
            Controls.Add(dgPayment);
            Controls.Add(dgWork);
            Controls.Add(dgCustomer);
            Name = "FrmPayment";
            Text = "FrmPayment";
            Load += FrmPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dgWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
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
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DateTimePicker dtDate;
        private Label label1;
        private Button btnSave;
        private Label label7;
        private TextBox txtPaid;
        private Label label8;
        private Label label2;
        private Label lbWork;
        private Label lbPayment;
        private Label label4;
        private Label lbDiff;
        private Label label5;
    }
}