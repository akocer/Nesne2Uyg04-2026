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
    public partial class FrmPayment : Form
    {
        public FrmPayment()
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
        void GetWorks(int customerId)
        {
            var works = db.Works.Where(s => s.CustomerId == customerId).ToList();
            dgWork.Rows.Clear();
            foreach (var work in works)
            {
                dgWork.Rows.Add(work.Id, work.Name, work.Customer.Name, work.Price);
            }
        }
        void GetPayments(int customerId)
        {
            var works = db.Payments.Where(s => s.CustomerId == customerId).ToList();
            dgPayment.Rows.Clear();
            foreach (var payment in works)
            {
                dgPayment.Rows.Add(payment.Id, payment.CreateDate, payment.Paid);
            }
        }
        private void FrmPayment_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void dgCustomer_Click(object sender, EventArgs e)
        {
            var customerId = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);
            GetWorks(customerId);
            GetPayments(customerId);
            Calculate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customerId = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);

            if (txtPaid.Text != "")
            {
                var paid = Convert.ToDouble(txtPaid.Text);
                var payment = new Payment();
                payment.Paid = paid;
                payment.CustomerId = customerId;
                payment.CreateDate = dtDate.Value;
                payment.UpdateDate = dtDate.Value;
                db.Payments.Add(payment);
                db.SaveChanges();


                GetPayments(customerId);
                Calculate();
            }
        }

            void Calculate()
            {
                double worktotal = 0;
                double paymenttotal = 0;
                for (int i = 0; i < dgWork.RowCount; i++)
                {
                    worktotal+=Convert.ToDouble(dgWork.Rows[i].Cells[3].Value.ToString());
                }
                for (int i = 0; i < dgPayment.RowCount; i++)
                {
                    paymenttotal += Convert.ToDouble(dgPayment.Rows[i].Cells[2].Value.ToString());
                }
                double diff = paymenttotal-worktotal;
                lbWork.Text=worktotal.ToString("0.00 TL");
                lbPayment.Text=paymenttotal.ToString("0.00 TL");
                lbDiff.Text = diff.ToString("0.00 TL");
                if (diff < 0)
                {
                    lbDiff.ForeColor = Color.Red;
                }else
                {
                    lbDiff.ForeColor = Color.Green;
                }

            }
        }
    }

