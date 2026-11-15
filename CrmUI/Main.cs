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
            var catalogCustomer = new Catalog<Customer>(dbContext.Customers);
            catalogCustomer.Show();
        }



        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(dbContext.Sellers);
            catalogSeller.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(dbContext.Products);
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
                dbContext.SaveChangesAsync();
            }
        }

        private void SellerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() != DialogResult.OK)
            {
                dbContext.Sellers.Add(form.Seller);
                dbContext.SaveChangesAsync();
            }
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() != DialogResult.OK)
            {
                dbContext.Products.Add(form.Product);
                dbContext.SaveChangesAsync();
            }
        }
    }
}
