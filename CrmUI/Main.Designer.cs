namespace CrmUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            сущностиToolStripMenuItem = new ToolStripMenuItem();
            ProductToolStripMenuItem = new ToolStripMenuItem();
            SellerToolStripMenuItem = new ToolStripMenuItem();
            SellerAddToolStripMenuItem = new ToolStripMenuItem();
            CustomerToolStripMenuItem = new ToolStripMenuItem();
            CustomerAddToolStripMenuItem = new ToolStripMenuItem();
            чекToolStripMenuItem = new ToolStripMenuItem();
            ProductAddToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { сущностиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            сущностиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProductToolStripMenuItem, SellerToolStripMenuItem, CustomerToolStripMenuItem, чекToolStripMenuItem });
            сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            сущностиToolStripMenuItem.Size = new Size(76, 20);
            сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // ProductToolStripMenuItem
            // 
            ProductToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProductAddToolStripMenuItem });
            ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            ProductToolStripMenuItem.Size = new Size(180, 22);
            ProductToolStripMenuItem.Text = "Продукты";
            ProductToolStripMenuItem.Click += ProductToolStripMenuItem_Click;
            // 
            // SellerToolStripMenuItem
            // 
            SellerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SellerAddToolStripMenuItem });
            SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            SellerToolStripMenuItem.Size = new Size(180, 22);
            SellerToolStripMenuItem.Text = "Продавцы";
            SellerToolStripMenuItem.Click += SellerToolStripMenuItem_Click;
            // 
            // SellerAddToolStripMenuItem
            // 
            SellerAddToolStripMenuItem.Name = "SellerAddToolStripMenuItem";
            SellerAddToolStripMenuItem.Size = new Size(180, 22);
            SellerAddToolStripMenuItem.Text = "Добавить";
            SellerAddToolStripMenuItem.Click += SellerAddToolStripMenuItem_Click;
            // 
            // CustomerToolStripMenuItem
            // 
            CustomerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CustomerAddToolStripMenuItem });
            CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            CustomerToolStripMenuItem.Size = new Size(180, 22);
            CustomerToolStripMenuItem.Text = "Покупатели";
            CustomerToolStripMenuItem.Click += CustomerToolStripMenuItem_Click;
            // 
            // CustomerAddToolStripMenuItem
            // 
            CustomerAddToolStripMenuItem.Name = "CustomerAddToolStripMenuItem";
            CustomerAddToolStripMenuItem.Size = new Size(126, 22);
            CustomerAddToolStripMenuItem.Text = "Добавить";
            CustomerAddToolStripMenuItem.Click += CustomerAddToolStripMenuItem_Click;
            // 
            // чекToolStripMenuItem
            // 
            чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            чекToolStripMenuItem.Size = new Size(180, 22);
            чекToolStripMenuItem.Text = "Чек";
            чекToolStripMenuItem.Click += CheckToolStripMenuItem_Click;
            // 
            // ProductAddToolStripMenuItem
            // 
            ProductAddToolStripMenuItem.Name = "ProductAddToolStripMenuItem";
            ProductAddToolStripMenuItem.Size = new Size(180, 22);
            ProductAddToolStripMenuItem.Text = "Добавить";
            ProductAddToolStripMenuItem.Click += ProductAddToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem сущностиToolStripMenuItem;
        private ToolStripMenuItem ProductToolStripMenuItem;
        private ToolStripMenuItem SellerToolStripMenuItem;
        private ToolStripMenuItem CustomerToolStripMenuItem;
        private ToolStripMenuItem чекToolStripMenuItem;
        private ToolStripMenuItem CustomerAddToolStripMenuItem;
        private ToolStripMenuItem SellerAddToolStripMenuItem;
        private ToolStripMenuItem ProductAddToolStripMenuItem;
    }
}
