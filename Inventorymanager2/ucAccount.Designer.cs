namespace Inventorymanager2
{
    partial class ucAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewAccoutList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccoutList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAccoutList
            // 
            this.gridViewAccoutList.AllowUserToAddRows = false;
            this.gridViewAccoutList.AllowUserToDeleteRows = false;
            this.gridViewAccoutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAccoutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.DisplayName,
            this.Role});
            this.gridViewAccoutList.Location = new System.Drawing.Point(171, 40);
            this.gridViewAccoutList.Name = "gridViewAccoutList";
            this.gridViewAccoutList.RowHeadersVisible = false;
            this.gridViewAccoutList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewAccoutList.Size = new System.Drawing.Size(544, 501);
            this.gridViewAccoutList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Location = new System.Drawing.Point(16, 122);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(136, 49);
            this.btnDelAcc.TabIndex = 2;
            this.btnDelAcc.Text = "Xóa tài khoản";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.Location = new System.Drawing.Point(16, 204);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(136, 49);
            this.btnEditAcc.TabIndex = 3;
            this.btnEditAcc.Text = "Sửa tài khoản";
            this.btnEditAcc.UseVisualStyleBackColor = true;
            this.btnEditAcc.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(640, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 150;
            // 
            // DisplayName
            // 
            this.DisplayName.FillWeight = 150F;
            this.DisplayName.HeaderText = "Tên";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Width = 295;
            // 
            // Role
            // 
            this.Role.HeaderText = "Phân quyền";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 99;
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEditAcc);
            this.Controls.Add(this.btnDelAcc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridViewAccoutList);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(740, 569);
            this.Load += new System.EventHandler(this.ucAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccoutList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewAccoutList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
