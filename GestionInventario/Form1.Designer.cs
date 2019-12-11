namespace GestionInventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.debugStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newRegButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridtab2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showEx = new System.Windows.Forms.Button();
            this.addInvReg = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.disccountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotalBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shopList = new System.Windows.Forms.DataGridView();
            this.searchItemButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adeudCashLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalCashLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtab2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugStatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(973, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "Debug Log";
            // 
            // debugStatusBar
            // 
            this.debugStatusBar.Name = "debugStatusBar";
            this.debugStatusBar.Size = new System.Drawing.Size(57, 17);
            this.debugStatusBar.Text = "Initialized";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // newRegButton
            // 
            this.newRegButton.Location = new System.Drawing.Point(12, 13);
            this.newRegButton.Name = "newRegButton";
            this.newRegButton.Size = new System.Drawing.Size(117, 78);
            this.newRegButton.TabIndex = 2;
            this.newRegButton.Text = "Nuevo";
            this.newRegButton.UseVisualStyleBackColor = true;
            this.newRegButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 490);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soluciones Informaticas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridtab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DK Laboratorio Celular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridtab2
            // 
            this.dataGridtab2.AllowUserToAddRows = false;
            this.dataGridtab2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridtab2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridtab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtab2.Location = new System.Drawing.Point(0, 0);
            this.dataGridtab2.Name = "dataGridtab2";
            this.dataGridtab2.Size = new System.Drawing.Size(941, 464);
            this.dataGridtab2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.cashButton);
            this.tabPage3.Controls.Add(this.TotalBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.disccountBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.subTotalBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.shopList);
            this.tabPage3.Controls.Add(this.searchItemButton);
            this.tabPage3.Controls.Add(this.searchBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(941, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Venta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.showEx);
            this.panel1.Controls.Add(this.addInvReg);
            this.panel1.Location = new System.Drawing.Point(9, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 102);
            this.panel1.TabIndex = 11;
            // 
            // showEx
            // 
            this.showEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEx.Location = new System.Drawing.Point(4, 42);
            this.showEx.Name = "showEx";
            this.showEx.Size = new System.Drawing.Size(144, 30);
            this.showEx.TabIndex = 1;
            this.showEx.Text = "Ver existencias";
            this.showEx.UseVisualStyleBackColor = true;
            this.showEx.Click += new System.EventHandler(this.showEx_Click);
            // 
            // addInvReg
            // 
            this.addInvReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvReg.Location = new System.Drawing.Point(4, 6);
            this.addInvReg.Name = "addInvReg";
            this.addInvReg.Size = new System.Drawing.Size(144, 30);
            this.addInvReg.TabIndex = 0;
            this.addInvReg.Text = "Añadir al inventario";
            this.addInvReg.UseVisualStyleBackColor = true;
            this.addInvReg.Click += new System.EventHandler(this.addInvReg_Click);
            // 
            // cashButton
            // 
            this.cashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashButton.Location = new System.Drawing.Point(788, 349);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(150, 100);
            this.cashButton.TabIndex = 10;
            this.cashButton.Text = "Cobrar";
            this.cashButton.UseVisualStyleBackColor = true;
            // 
            // TotalBox
            // 
            this.TotalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBox.Location = new System.Drawing.Point(642, 421);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(140, 30);
            this.TotalBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // disccountBox
            // 
            this.disccountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disccountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disccountBox.Location = new System.Drawing.Point(642, 385);
            this.disccountBox.Name = "disccountBox";
            this.disccountBox.Size = new System.Drawing.Size(140, 30);
            this.disccountBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descuento";
            // 
            // subTotalBox
            // 
            this.subTotalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalBox.Location = new System.Drawing.Point(642, 349);
            this.subTotalBox.Name = "subTotalBox";
            this.subTotalBox.Size = new System.Drawing.Size(140, 30);
            this.subTotalBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subtotal";
            // 
            // shopList
            // 
            this.shopList.AllowUserToAddRows = false;
            this.shopList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.shopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulo,
            this.qty,
            this.price,
            this.totalQty});
            this.shopList.Location = new System.Drawing.Point(3, 40);
            this.shopList.Name = "shopList";
            this.shopList.Size = new System.Drawing.Size(935, 303);
            this.shopList.TabIndex = 3;
            // 
            // searchItemButton
            // 
            this.searchItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemButton.Location = new System.Drawing.Point(798, 4);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(140, 30);
            this.searchItemButton.TabIndex = 2;
            this.searchItemButton.Text = "Buscar";
            this.searchItemButton.UseVisualStyleBackColor = true;
            this.searchItemButton.Click += new System.EventHandler(this.searchItemButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(100, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(692, 30);
            this.searchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 77);
            this.button2.TabIndex = 5;
            this.button2.Text = "Entrada caja soluciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.adeudCashLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.saldoLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.totalCashLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(258, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 78);
            this.panel2.TabIndex = 6;
            // 
            // adeudCashLabel
            // 
            this.adeudCashLabel.AutoSize = true;
            this.adeudCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adeudCashLabel.ForeColor = System.Drawing.Color.Red;
            this.adeudCashLabel.Location = new System.Drawing.Point(265, 57);
            this.adeudCashLabel.Name = "adeudCashLabel";
            this.adeudCashLabel.Size = new System.Drawing.Size(58, 20);
            this.adeudCashLabel.TabIndex = 5;
            this.adeudCashLabel.Text = "$00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "DEUDA ACTUAL";
            // 
            // saldoLabel
            // 
            this.saldoLabel.AutoSize = true;
            this.saldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.saldoLabel.Location = new System.Drawing.Point(265, 28);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(58, 20);
            this.saldoLabel.TabIndex = 3;
            this.saldoLabel.Text = "$00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "DEUDA TOTAL SOLUCIONES";
            // 
            // totalCashLabel
            // 
            this.totalCashLabel.AutoSize = true;
            this.totalCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCashLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalCashLabel.Location = new System.Drawing.Point(265, 4);
            this.totalCashLabel.Name = "totalCashLabel";
            this.totalCashLabel.Size = new System.Drawing.Size(58, 20);
            this.totalCashLabel.TabIndex = 1;
            this.totalCashLabel.Text = "$00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "CAJA TOTAL SOLUCIONES";
            // 
            // articulo
            // 
            this.articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articulo.HeaderText = "Descripción";
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Cantidad";
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // totalQty
            // 
            this.totalQty.HeaderText = "Total";
            this.totalQty.Name = "totalQty";
            this.totalQty.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.newRegButton);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Inventarios & venta";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtab2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel debugStatusBar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newRegButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridtab2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button searchItemButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox disccountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subTotalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView shopList;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addInvReg;
        private System.Windows.Forms.Button showEx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalCashLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label adeudCashLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQty;
    }
}

