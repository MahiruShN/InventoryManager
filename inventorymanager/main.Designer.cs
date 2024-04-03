namespace inventorymanager
{
    partial class main
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
            pnlMenu = new Panel();
            button3 = new Button();
            btnItemsM = new Button();
            btnAccM = new Button();
            pnlApp = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Wheat;
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(btnItemsM);
            pnlMenu.Controls.Add(btnAccM);
            pnlMenu.Location = new Point(12, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(171, 637);
            pnlMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Location = new Point(3, 594);
            button3.Name = "button3";
            button3.Size = new Size(165, 40);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnItemsM
            // 
            btnItemsM.BackColor = Color.DarkCyan;
            btnItemsM.Location = new Point(3, 49);
            btnItemsM.Name = "btnItemsM";
            btnItemsM.Size = new Size(165, 40);
            btnItemsM.TabIndex = 1;
            btnItemsM.Text = "Quản lý Items";
            btnItemsM.UseVisualStyleBackColor = false;
            btnItemsM.Click += btnItemsM_Click;
            // 
            // btnAccM
            // 
            btnAccM.BackColor = Color.DarkCyan;
            btnAccM.Location = new Point(3, 3);
            btnAccM.Name = "btnAccM";
            btnAccM.Size = new Size(165, 40);
            btnAccM.TabIndex = 0;
            btnAccM.Text = "Quản lý tài khoản";
            btnAccM.UseVisualStyleBackColor = false;
            btnAccM.Click += btnAccM_Click;
            // 
            // pnlApp
            // 
            pnlApp.Location = new Point(189, 12);
            pnlApp.Name = "pnlApp";
            pnlApp.Size = new Size(983, 637);
            pnlApp.TabIndex = 1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1184, 661);
            Controls.Add(pnlApp);
            Controls.Add(pnlMenu);
            Name = "main";
            Text = "Form1";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlApp;
        private Button button3;
        private Button btnItemsM;
        private Button btnAccM;
    }
}
