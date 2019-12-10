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
    public partial class qtyEdit : Form
    {
        string identifier = "";
        public qtyEdit(string id)
        {
            InitializeComponent();
            identifier = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
            SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
            using (SQLiteCommand updateData = new SQLiteCommand("UPDATE inventario SET qty = @qty WHERE id = " + identifier, sqlCon))
            {
                updateData.Parameters.Add(new SQLiteParameter("@qty") { Value = qtyBox.Text });
                sqlCon.Open();
                updateData.ExecuteNonQuery();
                sqlCon.Close();
                this.Close();
            };            
        }
    }
}
