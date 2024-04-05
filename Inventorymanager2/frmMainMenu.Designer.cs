namespace Inventorymanager2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnObject = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInput);
            this.panel1.Controls.Add(this.btnObject);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 569);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(3, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xuất hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInput.Location = new System.Drawing.Point(3, 42);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(147, 33);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Nhập hàng";
            this.btnInput.UseVisualStyleBackColor = false;
            // 
            // btnObject
            // 
            this.btnObject.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnObject.Location = new System.Drawing.Point(3, 533);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(147, 33);
            this.btnObject.TabIndex = 1;
            this.btnObject.Text = "Quản lý tài khoản";
            this.btnObject.UseVisualStyleBackColor = false;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(147, 33);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Quản lý mặt hàng";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(171, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 569);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tra cứu tồn kho";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnObject;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button button2;
    }
}