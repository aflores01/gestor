namespace GestionInventario
{
    partial class bdeditForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.inputEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.inputTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputFalla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputComent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipo";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 402);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // inputEquipo
            // 
            this.inputEquipo.Location = new System.Drawing.Point(26, 50);
            this.inputEquipo.Name = "inputEquipo";
            this.inputEquipo.Size = new System.Drawing.Size(347, 20);
            this.inputEquipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // inputCliente
            // 
            this.inputCliente.Location = new System.Drawing.Point(26, 106);
            this.inputCliente.Name = "inputCliente";
            this.inputCliente.Size = new System.Drawing.Size(347, 20);
            this.inputCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // inputFecha
            // 
            this.inputFecha.Location = new System.Drawing.Point(26, 162);
            this.inputFecha.Name = "inputFecha";
            this.inputFecha.Size = new System.Drawing.Size(347, 20);
            this.inputFecha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono de contacto";
            // 
            // inputTelefono
            // 
            this.inputTelefono.Location = new System.Drawing.Point(26, 214);
            this.inputTelefono.Name = "inputTelefono";
            this.inputTelefono.Size = new System.Drawing.Size(347, 20);
            this.inputTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Falla";
            // 
            // inputFalla
            // 
            this.inputFalla.Location = new System.Drawing.Point(26, 270);
            this.inputFalla.Name = "inputFalla";
            this.inputFalla.Size = new System.Drawing.Size(347, 20);
            this.inputFalla.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Presupuesto";
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(26, 326);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(347, 20);
            this.inputCost.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comentario";
            // 
            // inputComent
            // 
            this.inputComent.Location = new System.Drawing.Point(26, 382);
            this.inputComent.Name = "inputComent";
            this.inputComent.Size = new System.Drawing.Size(347, 20);
            this.inputComent.TabIndex = 15;
            // 
            // bdeditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 479);
            this.Controls.Add(this.inputComent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputFalla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "bdeditForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar registro";
            this.Shown += new System.EventHandler(this.bdeditForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox inputEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inputFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputFalla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputComent; 
    }
}