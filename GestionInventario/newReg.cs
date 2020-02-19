using LibPrintTicket;
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
    public partial class newReg : Form
    {
        string baseSelected = "";
        public newReg(string dbSelect)
        {
            InitializeComponent();
            baseSelected = dbSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(inputEquipo.Text))
            {
                MessageBox.Show("Falta equipo");
            }
            else if (String.IsNullOrWhiteSpace(inputCliente.Text)) 
            {
                MessageBox.Show("Falta cliente");
            }
            else if (String.IsNullOrWhiteSpace(inputTelefono.Text))
            {
                MessageBox.Show("Falta teléfono");
            }
            else if (String.IsNullOrWhiteSpace(inputFalla.Text))
            {
                MessageBox.Show("Falta falla");
            }
            else if (String.IsNullOrWhiteSpace(inputCost.Text))
            {
                MessageBox.Show("Falta costo");
            }
            else if (String.IsNullOrWhiteSpace(inputComent.Text))
            {
                MessageBox.Show("Falta comentario");
            }
            else
            {
                try
                {
                    string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
                    SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
                    using (SQLiteCommand insertData = new SQLiteCommand("INSERT INTO "+ baseSelected +" (modelo,cliente,fecha,telefono,reparacion,costo,coment) values(@modelo,@cliente,@fecha,@telefono,@reparacion,@costo,@coment)", sqlCon))
                    {
                        insertData.Parameters.Add(new SQLiteParameter("@modelo") { Value = inputEquipo.Text });
                        insertData.Parameters.Add(new SQLiteParameter("@cliente") { Value = inputCliente.Text });
                        insertData.Parameters.Add(new SQLiteParameter("@fecha") { Value = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() });
                        insertData.Parameters.Add(new SQLiteParameter("@telefono") { Value = inputTelefono.Text });
                        insertData.Parameters.Add(new SQLiteParameter("@reparacion") { Value = inputFalla.Text });
                        insertData.Parameters.Add(new SQLiteParameter("@costo") { Value = inputCost.Text });
                        insertData.Parameters.Add(new SQLiteParameter("@coment") { Value = inputComent.Text });
                        sqlCon.Open();
                        insertData.ExecuteNonQuery();
                        sqlCon.Close();
                        if (baseSelected == "local") {
                            ticketClass tick = new ticketClass();
                            tick.PrintTicket(inputCliente.Text, inputTelefono.Text, inputEquipo.Text, inputFalla.Text, inputCost.Text, inputComent.Text); 
                        }
                    };
                }
                catch (Exception r)
                {
                    MessageBox.Show(r.ToString());
                }
            }
        }
    }
}
