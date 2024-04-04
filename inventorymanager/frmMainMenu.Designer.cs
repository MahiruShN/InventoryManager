namespace inventorymanager
{
    partial class frmMainMenu
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
            mainPanel = new Panel();
            panel2 = new Panel();
            btnProducts = new Button();
            btnCustomers = new Button();
            btnAccounts = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(40, 50, 66);
            mainPanel.Location = new Point(178, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(994, 637);
            mainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 78, 120);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnCustomers);
            panel2.Controls.Add(btnAccounts);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 637);
            panel2.TabIndex = 1;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(92, 165, 204);
            btnProducts.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(3, 89);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(154, 37);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Sản phẩm";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(92, 165, 204);
            btnCustomers.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(3, 46);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(154, 37);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Khách hàng";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.BackColor = Color.FromArgb(92, 165, 204);
            btnAccounts.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccounts.Location = new Point(3, 3);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(154, 37);
            btnAccounts.TabIndex = 0;
            btnAccounts.Text = "Tài khoản";
            btnAccounts.UseVisualStyleBackColor = false;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 165, 204);
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 597);
            button1.Name = "button1";
            button1.Size = new Size(154, 37);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 78, 120);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel2);
            Controls.Add(mainPanel);
            Name = "frmMainMenu";
            Text = "frmMainMenu";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel2;
        private Button btnProducts;
        private Button btnCustomers;
        private Button btnAccounts;
        private Button button1;
    }
}