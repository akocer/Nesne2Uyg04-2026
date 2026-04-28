using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nesne2Uyg04_2026.Models;

namespace Nesne2Uyg04_2026.Forms
{
    public partial class FrmWork : Form
    {
        public FrmWork()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        void GetCustomers()
        {
            var customers = db.Customers.ToList();
            dgCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                dgCustomer.Rows.Add(customer.Id, customer.Name, customer.Email, customer.Phone);
            }
        }
        void GetWorks()
        {
            var works = db.Works.ToList();
            dgWork.Rows.Clear();
            foreach (var work in works)
            {
                dgWork.Rows.Add(work.Id, work.Name, work.Customer.Name, work.Price);
            }
        }
        private void FrmWork_Load(object sender, EventArgs e)
        {
            dgCustomer.Visible = false;
            GetCustomers();
            GetWorks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgCustomer.Visible = true;
            dgWork.Visible = false;
        }

        private void dgCustomer_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgCustomer.CurrentRow.Cells[3].Value.ToString();

            dgCustomer.Visible = false;
            dgWork.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtTitle.Text == "" || txtDescription.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var price = Convert.ToDouble(txtPrice.Text);
            var id = Convert.ToInt32(txtId.Text);
            var work = new Work();
            work.CustomerId = id;
            work.Name = txtTitle.Text;
            work.Description = txtDescription.Text;
            work.CreateDate = dtDate.Value;
            work.UpdateDate = dtDate.Value;
            work.Price = price;
            db.Works.Add(work);
            db.SaveChanges();

            if (txtPaid.Text != "")
            {
                var paid = Convert.ToDouble(txtPaid.Text);
                var payment = new Payment();
                payment.Paid = paid;
                payment.CustomerId = id;
                payment.CreateDate = dtDate.Value;
                payment.UpdateDate = dtDate.Value;
                db.Payments.Add(payment);
                db.SaveChanges();
            }

            MessageBox.Show("İş Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }   
        }
    }
}
 