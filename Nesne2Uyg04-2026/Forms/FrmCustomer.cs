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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
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
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Customers.Count(c => c.Phone == txtPhone.Text) > 0)
            {
                MessageBox.Show("Girilen Telefon Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customer = new Customer();
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCustomers();
            btnClear.PerformClick();

        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgCustomer.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customerId = Convert.ToInt32(txtId.Text);
            var customer = db.Customers.Where(s => s.Id == customerId).FirstOrDefault();
            if (customer == null)
            {
                MessageBox.Show("Müşteri Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            db.Customers.Update(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCustomers();
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen kayıt seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customerId = Convert.ToInt32(txtId.Text);
            var customer = db.Customers.Where(s => s.Id == customerId).FirstOrDefault();
            if (customer == null)
            {
                MessageBox.Show("Müşteri Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            db.Customers.Remove(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCustomers();
            btnClear.PerformClick();
        }
    }
}
