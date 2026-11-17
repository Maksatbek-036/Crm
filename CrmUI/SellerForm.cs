using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
            
        }
        public SellerForm(Seller seller):this()
        {
           
            Seller = seller;
            textBox1.Text= seller.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name=textBox1.Text;      
            Close();
        }
    }
}
