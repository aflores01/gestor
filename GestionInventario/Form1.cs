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
        static string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
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
            } else if (tabControl1.SelectedTab == tabPage2)
            {
                dataBase = "local";
            }
            Form newReg = new newReg(dataBase);
            newReg.ShowDialog();
            debugStatusBar.Text = "Actualizado";
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
                //datagridviewbuttoncolum
                DataGridViewButtonColumn editarButton = new DataGridViewButtonColumn();
                editarButton.Name = "Editar";
                editarButton.Text = "Editar";
                editarButton.UseColumnTextForButtonValue = true;
                editarButton.HeaderText = "Realizar Cambios";
                int columnIndex = 0;
                if (dataGridView1.Columns["Editar"] == null)
                {
                    dataGridView1.Columns.Insert(columnIndex, editarButton);
                }
                dataGridView1.CellClick += DataGridView1_CellClick;
                //end
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
                DataGridViewButtonColumn editarButton = new DataGridViewButtonColumn();
                editarButton.Name = "Editar";
                editarButton.Text = "Editar";
                editarButton.UseColumnTextForButtonValue = true;
                editarButton.HeaderText = "Realizar Cambios";
                int columnIndex = 2;
                if (dataGridtab2.Columns["Editar"] == null)
                {
                    dataGridtab2.Columns.Insert(columnIndex, editarButton);
                }
                dataGridtab2.CellClick += DataGridtab2_CellClick;
                //end 
            }
            catch (Exception e)
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
                bdeditForm.ShowDialog();
            }
        }

        private void Form1_Activated_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadDB();
            loadDB2();
        }
    }
}
