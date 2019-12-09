using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class addToInv : Form
    {
        public addToInv()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(skuInput.Text))
            {
                MessageBox.Show("Falta SKU");
            }
            else if (string.IsNullOrWhiteSpace(descInput.Text))
            {
                MessageBox.Show("Falta Descripción");
            }
            else if (string.IsNullOrWhiteSpace(qtyInput.Text))
            {
                MessageBox.Show("Falta Cantidad");
            }
            else if (string.IsNullOrWhiteSpace(priceInput.Text))
            {
                MessageBox.Show("Falta Precio");
            }
            else 
            {
                string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
                SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
                using (SQLiteCommand insertData = new SQLiteCommand("INSERT INTO inventario (sku,name,qty,price) VALUES (@sku,@des,@qty,@price)",sqlCon) )
                {
                    insertData.Parameters.Add(new SQLiteParameter("@sku") {Value = skuInput.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@des") { Value = descInput.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@qty") { Value = qtyInput.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@price") { Value = priceInput.Text });
                    sqlCon.Open();
                    insertData.ExecuteNonQuery();
                    sqlCon.Close();
                    this.Close();
                }
            }
        }
    }
}
