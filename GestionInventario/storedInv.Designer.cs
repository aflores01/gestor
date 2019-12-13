namespace GestionInventario
{
    partial class storedInv
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
            this.invViewGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.invViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invViewGrid
            // 
            this.invViewGrid.AllowUserToAddRows = false;
            this.invViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invViewGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.invViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invViewGrid.Location = new System.Drawing.Point(13, 13);
            this.invViewGrid.Name = "invViewGrid";
            this.invViewGrid.Size = new System.Drawing.Size(960, 425);
            this.invViewGrid.TabIndex = 0;
            // 
            // storedInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.invViewGrid);
            this.Name = "storedInv";
            this.Text = "Existencias";
            ((System.ComponentModel.ISupportInitialize)(this.invViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView invViewGrid;
    }
}