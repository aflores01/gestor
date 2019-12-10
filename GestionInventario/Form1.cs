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
using System.Data.SqlClient;

namespace GestionInventario
{
    public partial class Form1 : Form
    {
        static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
        SQLiteConnection sqlCon = new SQLiteConnection(urI);
        
        public Form1()
        {
            InitializeComponent();
            loadDB();
            loadDB2();
            debugStatusBar.Text = "Conexión a base de datos correcta";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataBase = "";
            if (tabControl1.SelectedTab == tabPage1)
            {
                dataBase = "equipos";
                Form newReg = new newReg(dataBase);
                if (newReg.ShowDialog() == DialogResult.OK || newReg.ShowDialog() == DialogResult.Cancel)
                {
                    loadDB();
                    loadDB2();
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                dataBase = "local";
                Form newReg = new newReg(dataBase);
                if (newReg.ShowDialog() == DialogResult.OK || newReg.ShowDialog() == DialogResult.Cancel)
                {
                    loadDB();
                    loadDB2();
                }
            }
            else
            {
                debugStatusBar.Text = "No se puede insertar registro: Use el control de inventarios interno.";
            }
        }

        public void loadDB()
        {
            dataGridView1.DataSource = null;
            try
            {
                sqlCon.Open();
                SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM equipos", sqlCon);
                DataTable dT = new DataTable();
                adpt.Fill(dT);
                dataGridView1.DataSource = dT;
                DataGridViewButtonColumn editarButton = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Realizar Cambios"
                };
                int columnIndex = 0;
                if (dataGridView1.Columns["Editar"] == null)
                {
                    dataGridView1.Columns.Insert(columnIndex, editarButton);
                }
                dataGridView1.CellClick += DataGridView1_CellClick;
            }
            catch (Exception e)
            {
                debugStatusBar.Text = "Conexión fallida: " + e.ToString();
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public void loadDB2()
        {
            dataGridtab2.DataSource = null;
            try
            {
                sqlCon.Open();
                SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM local", sqlCon);
                DataTable dT = new DataTable();
                adpt.Fill(dT);
                dataGridtab2.DataSource = dT;
                //datagridviewbuttoncolum
                DataGridViewButtonColumn editarButton = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Realizar Cambios"
                };
                int columnIndex = 0;
                if (dataGridtab2.Columns["Editar"] == null)
                {
                    dataGridtab2.Columns.Insert(columnIndex, editarButton);
                }
                dataGridtab2.CellClick += DataGridtab2_CellClick;
                //end 
            }
            catch (Exception)
            {
                debugStatusBar.Text = "No hay datos a mostrar.";
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void DataGridtab2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridtab2.Columns["Editar"].Index)
            {
                DataGridViewRow rowNumber = dataGridtab2.Rows[e.RowIndex];
                string iD = rowNumber.Cells["id"].Value.ToString();
                string selectedBD = tabPage2.Text;
                Form bdeditForm = new bdeditForm(selectedBD);
                bdeditForm.Tag = iD;
                if (bdeditForm.ShowDialog() == DialogResult.OK || bdeditForm.ShowDialog() == DialogResult.Cancel)
                {
                    loadDB();
                    loadDB2();
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index) 
            {
                DataGridViewRow rowNumber = dataGridView1.Rows[e.RowIndex];
                string iD = rowNumber.Cells["id"].Value.ToString();
                string selectedBD = tabPage1.Text;
                Form bdeditForm = new bdeditForm(selectedBD);
                bdeditForm.Tag = iD;
                if (bdeditForm.ShowDialog() == DialogResult.OK) 
                {
                    loadDB();
                    loadDB2();
                }
            }
        }

        private void addInvReg_Click(object sender, EventArgs e)
        {
            Form addToInv = new addToInv();
            addToInv.ShowDialog();
        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                MessageBox.Show("Introduce tu busqueda");
            }
            else 
            {
                string busqueda = searchBox.Text;
                Form searchPos = new searchResultsPOS(busqueda);
                searchPos.ShowDialog();
                searchBox.Text = "";
            }
        }

        private void showEx_Click(object sender, EventArgs e)
        {
            Form newForm = new storedInv();
            newForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newIncoming = new incomingRecord();
            if (newIncoming.ShowDialog() == DialogResult.OK)
            {
                loadDB();
                loadDB2();
            }
        }
    }
}
