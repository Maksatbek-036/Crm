using CrmBL;
using CrmBL.Model;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmContext dbContext;
        public Main()
        {
            InitializeComponent();
            dbContext = new CrmContext();

        }


        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(dbContext.Customers,dbContext);
            catalogCustomer.Show();
        }



        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(dbContext.Sellers,dbContext);
            catalogSeller.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(dbContext.Products,dbContext);
            catalogProduct.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void CustomerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() != DialogResult.OK)
            {
                dbContext.Customers.Add(form.Customer);
                dbContext.SaveChanges();
            }
        }

        private void SellerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() != DialogResult.OK)
            {
                dbContext.Sellers.Add(form.Seller);
                dbContext.SaveChanges();
            }
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() != DialogResult.OK)
            {
                dbContext.Products.Add(form.Product);
                dbContext.SaveChanges();
            }
        }
    }
}
