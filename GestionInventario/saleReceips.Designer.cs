namespace GestionInventario
{
    partial class saleReceips
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
            this.label1 = new System.Windows.Forms.Label();
            this.folioTextBox = new System.Windows.Forms.TextBox();
            this.searchReceip = new System.Windows.Forms.Button();
            this.receipsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.receipsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por folio:";
            // 
            // folioTextBox
            // 
            this.folioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folioTextBox.Location = new System.Drawing.Point(164, 6);
            this.folioTextBox.Name = "folioTextBox";
            this.folioTextBox.Size = new System.Drawing.Size(476, 26);
            this.folioTextBox.TabIndex = 1;
            // 
            // searchReceip
            // 
            this.searchReceip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchReceip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReceip.Location = new System.Drawing.Point(646, 6);
            this.searchReceip.Name = "searchReceip";
            this.searchReceip.Size = new System.Drawing.Size(142, 26);
            this.searchReceip.TabIndex = 2;
            this.searchReceip.Text = "Buscar";
            this.searchReceip.UseVisualStyleBackColor = true;
            // 
            // receipsGridView
            // 
            this.receipsGridView.AllowUserToAddRows = false;
            this.receipsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receipsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.receipsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipsGridView.Location = new System.Drawing.Point(12, 38);
            this.receipsGridView.Name = "receipsGridView";
            this.receipsGridView.Size = new System.Drawing.Size(776, 400);
            this.receipsGridView.TabIndex = 3;
            // 
            // saleReceips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receipsGridView);
            this.Controls.Add(this.searchReceip);
            this.Controls.Add(this.folioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "saleReceips";
            this.Text = "saleReceips";
            ((System.ComponentModel.ISupportInitialize)(this.receipsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folioTextBox;
        private System.Windows.Forms.Button searchReceip;
        private System.Windows.Forms.DataGridView receipsGridView;
    }
}