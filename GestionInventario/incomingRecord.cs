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
    public partial class incomingRecord : Form
    {
        string maxId = "";
        public incomingRecord()
        {
            InitializeComponent();
            string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
            SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
            SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT MAX(id) FROM equipos",sqlCon);
            DataTable dt = new DataTable();
            sqlCon.Open();
            adpt.Fill(dt);
            sqlCon.Close();
            maxId = dt.Rows[0]["MAX(id)"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
            SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
            using (SQLiteCommand inCom = new SQLiteCommand("UPDATE equipos SET saldo = @saldo WHERE id = " + maxId, sqlCon)) 
            {
                inCom.Parameters.Add(new SQLiteParameter("@saldo") { Value = cashBox.Text});
                sqlCon.Open();
                inCom.ExecuteNonQuery();
                sqlCon.Close();
                this.Close();
            };
        }
    }
}
