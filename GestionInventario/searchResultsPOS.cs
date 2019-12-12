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
    public partial class searchResultsPOS : Form
    {
        public string artId { get; set; }
        public searchResultsPOS(string busqueda)
        {
            InitializeComponent();
            string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
            SQLiteConnection sqlCon = new SQLiteConnection(urI);
            SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM inventario WHERE name LIKE '%" + busqueda +"%'",sqlCon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            searchResultGrid.DataSource = dt;
            sqlCon.Close();
            DataGridViewButtonColumn selectButton = new DataGridViewButtonColumn
            {
                Text = "Seleccionar",
                Name = "selectedButton",
                UseColumnTextForButtonValue = true,
                HeaderText = "Seleccionar"
            };
            if (searchResultGrid.Columns["Seleccionar"] == null) 
            {
                searchResultGrid.Columns.Insert(0,selectButton);
            }
            searchResultGrid.CellClick += SearchResultGrid_CellClick;
        }

        private void SearchResultGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == searchResultGrid.Columns["SelectedButton"].Index) 
            {
                DataGridViewRow dgbR = searchResultGrid.Rows[e.RowIndex];
                artId =  dgbR.Cells["id"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
