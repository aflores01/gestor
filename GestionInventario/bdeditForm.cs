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
    public partial class bdeditForm : Form
    {
        public bdeditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
                SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
                string idToUpdate = this.Tag.ToString();
                using (SQLiteCommand insertData = new SQLiteCommand("UPDATE equipos SET modelo = @modelo , cliente = @cliente , telefono = @telefono ,reparacion = @reparacion ,costo = @costo, coment = @coment WHERE id = " + idToUpdate, sqlCon))
                {
                    insertData.Parameters.Add(new SQLiteParameter("@modelo") { Value = inputEquipo.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@cliente") { Value = inputCliente.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@telefono") { Value = inputTelefono.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@reparacion") { Value = inputFalla.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@costo") { Value = inputCost.Text });
                    insertData.Parameters.Add(new SQLiteParameter("@coment") { Value = inputComent.Text });
                    sqlCon.Open();
                    insertData.ExecuteNonQuery();
                    sqlCon.Close();
                    this.Close();
                };
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }
        }

        private void bdeditForm_Shown(object sender, EventArgs e)
        {
            try
            {
                string idToUpdate = this.Tag.ToString();
                string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
                SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
                sqlCon.Open();
                SQLiteDataAdapter adptSelect = new SQLiteDataAdapter("SELECT * FROM equipos WHERE id = " + idToUpdate, sqlCon);
                DataSet dt = new DataSet();
                adptSelect.Fill(dt);
                inputEquipo.Text = dt.Tables[0].Rows[0]["modelo"].ToString();
                inputCliente.Text = dt.Tables[0].Rows[0]["cliente"].ToString();
                inputTelefono.Text = dt.Tables[0].Rows[0]["telefono"].ToString();
                inputFalla.Text = dt.Tables[0].Rows[0]["reparacion"].ToString();
                inputCost.Text = dt.Tables[0].Rows[0]["costo"].ToString();
                inputComent.Text = dt.Tables[0].Rows[0]["coment"].ToString();
                sqlCon.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }
        }
    }
}
