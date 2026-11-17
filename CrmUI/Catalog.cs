using CrmBL;
using CrmBL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void button2_Click(object sender, EventArgs e)
        {

        }

        protected virtual void button3_Click(object sender, EventArgs e)
        {

        }
    }

    public partial class Catalog<T> :Catalog where T:class

    {
        CrmContext dbContext;
        DbSet<T> set;
        public Catalog(DbSet<T> set,CrmContext dbContext):base()
        {
            this.dbContext = dbContext;
            this.set = set;
            set.Load();
            dataGridView1.DataSource = set.ToList();

        }
     
        private void Catalog_Load(object sender, EventArgs e)
        {

        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product)) { 
            
            }
            if (typeof(T) == typeof(Seller))
            {

            }
            if (typeof(T) == typeof(Customer))
            {

            }
            base.button1_Click(sender, e);
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            if (typeof(T) == typeof(Product)) {
                var product=set.Find(id) as Product;
                if (product != null)
                {
                var form = new ProductForm(product);
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        product = form.Product;
                       
                        dbContext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                }

                
            }
            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;
                if (seller != null)
                {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        seller = form.Seller;

                        dbContext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                }
           
                }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = set.Find(id) as Customer;
                if (customer != null)
                {
                    var form = new CustomerForm(customer);
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        customer = form.Customer;

                        dbContext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                }

            }


            base.button2_Click(sender, e);
        }
        protected override void button3_Click(object sender, EventArgs e)
        {

            base.button3_Click(sender, e);
        }
      
    }
}
