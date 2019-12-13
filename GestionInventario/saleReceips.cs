using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GestionInventario
{
    public partial class saleReceips : Form
    {
        static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
        SQLiteConnection sqlCon = new SQLiteConnection(urI);
        public saleReceips()
        {
            InitializeComponent();
            try 
            {
                sqlCon.Open();
                SQLiteDataAdapter sqla = new SQLiteDataAdapter("SELECT * FROM sales", sqlCon);
                DataTable dt = new DataTable();
                sqla.Fill(dt);
                receipsGridView.DataSource = dt;
                sqlCon.Close();
            }
            catch 
            {
            }
        }
    }
}
