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
    public partial class storedInv : Form
    {
        public storedInv()
        {
            InitializeComponent();
            string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
            SQLiteConnection sqlCon = new SQLiteConnection(urI);
            SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM inventario", sqlCon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            invViewGrid.DataSource = dt;
            sqlCon.Close();
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn()
            {
                Text = "Editar",
                Name = "Editar",
                UseColumnTextForButtonValue = true,
                HeaderText = "Editar existencias"
            };
            invViewGrid.Columns.Insert(0,editButton);
            invViewGrid.CellClick += InvViewGrid_CellClick;
        }

        private void InvViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == invViewGrid.Columns["Editar"].Index) 
            {
                DataGridViewRow ind = invViewGrid.Rows[e.RowIndex];
                string id = ind.Cells["id"].Value.ToString();
                Form qtyEdit = new qtyEdit(id);
                qtyEdit.ShowDialog();
            }
        }
    }
}
