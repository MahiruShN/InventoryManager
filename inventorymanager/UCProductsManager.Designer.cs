namespace inventorymanager
{
    partial class UCProductsManager
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
            Items = new Label();
            SuspendLayout();
            // 
            // Items
            // 
            Items.AutoSize = true;
            Items.Location = new Point(385, 278);
            Items.Name = "Items";
            Items.Size = new Size(38, 15);
            Items.TabIndex = 0;
            Items.Text = "label1";
            // 
            // UCItemsManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Items);
            Name = "UCItemsManager";
            Size = new Size(983, 637);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Items;
    }
}
