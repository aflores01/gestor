using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace GestionInventario
{
    public partial class Form1 : Form
    {
        static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
        readonly SQLiteConnection sqlCon = new SQLiteConnection(urI);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataBase;
            if (tabControl1.SelectedTab == tabPage1)
            {
                dataBase = "equipos";
                Form newReg = new newReg(dataBase);
                if (newReg.ShowDialog() == DialogResult.OK)
                {
                    loadDB();
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                dataBase = "local";
                Form newReg = new newReg(dataBase);
                if (newReg.ShowDialog() == DialogResult.OK)
                {
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
                Db_search dbQuery = new Db_search();
                DataTable costo = dbQuery.Search_query("SELECT SUM(costo) FROM equipos");
                saldoLabel.Text = "$" + costo.Rows[0][0].ToString();
                DataTable saldo = dbQuery.Search_query("SELECT SUM(saldo) FROM equipos");
                totalCashLabel.Text = "$" + saldo.Rows[0][0].ToString();
                DataTable totales = dbQuery.Search_query("SELECT SUM(costo) - SUM(saldo) FROM equipos");
                adeudCashLabel.Text = "$" + totales.Rows[0][0].ToString();
                DataTable content = dbQuery.Search_query("SELECT * FROM equipos");
                dataGridView1.DataSource = content;
                DataGridViewButtonColumn delButn = new DataGridViewButtonColumn 
                {
                    Name = "Borrar",
                    Text = "Borrar",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Eliminar registro"
                };
                if (dataGridView1.Columns["Borrar"] == null)
                {
                    dataGridView1.Columns.Insert(0, delButn);
                }

                //
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
        }

        public void loadDB2()
        {
            dataGridtab2.DataSource = null;
            try
            {
                Db_search DBQuery = new Db_search();
                DataTable dt = DBQuery.Search_query("SELECT * from local where entregado ISNULL ORDER BY id DESC LIMIT 50");
                dataGridtab2.DataSource = dt;
                DataGridViewButtonColumn collected = new DataGridViewButtonColumn
                {
                    Name = "Entregar",
                    Text = "Entregar",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Recolección"
                };
                int columnCount = dt.Columns.Count;
                if (dataGridtab2.Columns["Entregar"] == null)
                {
                    dataGridtab2.Columns.Insert(0, collected);
                }
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
                //end 
                DataGridViewButtonColumn pdfB = new DataGridViewButtonColumn
                {
                    Name = "receip",
                    Text = "Imprimir",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Imprimir Nota"
                };
                int index = dataGridtab2.Columns.Count;
                if (dataGridtab2.Columns["receip"] == null) 
                {
                    dataGridtab2.Columns.Insert(1, pdfB);
                }
                dataGridtab2.CellClick += DataGridtab2_CellClick;
            }
            catch (Exception)
            {
                debugStatusBar.Text = "No hay datos a mostrar.";
            }
        }

        private void DataGridtab2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridtab2.Columns["receip"].Index)
            {
                DataGridViewRow rowNumber = dataGridtab2.Rows[e.RowIndex];
                ticketClass ticketImp = new ticketClass();
                ticketImp.PrintCopyTicket(
                    rowNumber.Cells["cliente"].Value.ToString(),
                    rowNumber.Cells["telefono"].Value.ToString(),
                    rowNumber.Cells["modelo"].Value.ToString(),
                    rowNumber.Cells["reparacion"].Value.ToString(),
                    rowNumber.Cells["costo"].Value.ToString(),
                    rowNumber.Cells["coment"].Value.ToString(),
                    rowNumber.Cells["fecha"].Value.ToString()
                    );
            }
            else if (e.ColumnIndex == dataGridtab2.Columns["Editar"].Index)
            {
                DataGridViewRow rowNumber = dataGridtab2.Rows[e.RowIndex];
                string iD = rowNumber.Cells["id"].Value.ToString();
                string selectedBD = tabPage2.Text;
                Form bdeditForm = new bdeditForm(selectedBD);
                bdeditForm.Tag = iD;
                if (bdeditForm.ShowDialog() == DialogResult.OK)
                {
                    loadDB();
                    loadDB2();
                }
            }
            else if (e.ColumnIndex == dataGridtab2.Columns["Entregar"].Index) 
            {
                try
                {
                    DataGridViewRow rowValue = dataGridtab2.Rows[e.RowIndex];
                    string id = rowValue.Cells["id"].Value.ToString();
                    var query_check = new query_consult();
                    query_check.query_data(id);
                    loadDB2();
                }
                catch { }
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
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["Borrar"].Index) 
            {
                DialogResult dgR = MessageBox.Show("Se borrará el registro ¿Estás Seguro?", "Confirmar", MessageBoxButtons.YesNo);
                if (dgR == DialogResult.Yes)
                {
                    DataGridViewRow rowNum = dataGridView1.Rows[e.RowIndex];
                    string iD = rowNum.Cells["id"].Value.ToString();
                    string uriDB = @"URI = file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
                    SQLiteConnection sqlCon = new SQLiteConnection(uriDB);
                    using (SQLiteCommand delCmnd = new SQLiteCommand("DELETE FROM equipos WHERE id = " + iD, sqlCon)) 
                    {
                        sqlCon.Open();
                        delCmnd.ExecuteNonQuery();
                        sqlCon.Close();
                    };
                    loadDB();
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
                searchBox.Text = "";
                using (searchResultsPOS searchPos = new searchResultsPOS(busqueda)) 
                {
                    if (searchPos.ShowDialog() == DialogResult.OK)
                    {
                        Db_search Db = new Db_search();
                        DataTable dT = Db.Search_query("SELECT * FROM inventario WHERE id = " + searchPos.artId);
                        int rowCount = shopList.Rows.Add();
                        DataGridViewRow newRow = shopList.Rows[rowCount];
                        newRow.Cells["id"].Value = dT.Rows[0]["id"].ToString();
                        newRow.Cells["sku"].Value = dT.Rows[0]["sku"].ToString();
                        newRow.Cells["articulo"].Value = dT.Rows[0]["name"].ToString();
                        newRow.Cells["qty"].Value = "1";
                        newRow.Cells["price"].Value = dT.Rows[0]["price"].ToString();
                        newRow.Cells["totalQty"].Value = dT.Rows[0]["price"].ToString();
                    } 
                }
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
            }
        }

        private void ShopList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow updateRow = shopList.CurrentRow;
                int valor1 = int.Parse(updateRow.Cells["qty"].Value.ToString());
                int valor2 = int.Parse(updateRow.Cells["price"].Value.ToString());

                updateRow.Cells["totalQty"].Value = (valor1 * valor2).ToString();
                int suma = 0;
                foreach (DataGridViewRow row in shopList.Rows) 
                {
                    int totalCount = int.Parse(row.Cells["totalQty"].Value.ToString());
                    suma += totalCount;
                    subTotalBox.Text = suma.ToString();
                }
                int subtotalValue = int.Parse(subTotalBox.Text);
                int totalDiscount = int.Parse(disccountBox.Text);
                if (disccountBox.Text == null)
                {
                    totalDiscount = 0;
                }
                TotalBox.Text = (subtotalValue - totalDiscount).ToString();
            }
            catch
            {
                
            }
        }

        private void disccountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int subtotalValue = int.Parse(subTotalBox.Text);
                int totalDiscount = int.Parse(disccountBox.Text);
                TotalBox.Text = (subtotalValue - totalDiscount).ToString();
            }
            catch { }
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            var iditemList = new List<string>();
            var priceitemList = new List<string>();
            var qtyitemList = new List<string>();
            foreach (DataGridViewRow row in shopList.Rows)
            {
                iditemList.Add(row.Cells["id"].Value.ToString());
                priceitemList.Add(row.Cells["price"].Value.ToString());
                qtyitemList.Add(row.Cells["qty"].Value.ToString());
                Db_search DB = new Db_search();
                DataTable dtID = DB.Search_query("SELECT qty FROM inventario WHERE id = " + row.Cells["id"].Value);
                int cantidad = (int.Parse(dtID.Rows[0][0].ToString()) - int.Parse(row.Cells["qty"].Value.ToString()));
                if (cantidad > 0)
                {
                    using (SQLiteCommand slqc = new SQLiteCommand("UPDATE inventario SET qty = @qty WHERE id = @id", sqlCon))
                    {
                        sqlCon.Open();
                        slqc.Parameters.Add(new SQLiteParameter("@id") { Value = row.Cells["id"].Value });
                        slqc.Parameters.Add(new SQLiteParameter("@qty") { Value = cantidad });
                        slqc.ExecuteNonQuery();
                        sqlCon.Close();
                    };
                }
                else
                {
                    debugStatusBar.Text = "No hay existencias disponibles para venta";
                }
            }
            string listId = "";
            string pricesStr = "";
            string qtyStr = "";
            foreach (var idString in iditemList)
            {
                listId = idString + " ";
            }
            foreach (var pricesString in priceitemList)
            {
                pricesStr = pricesString + " ";
            }
            foreach (var qtyString in qtyitemList)
            {
                qtyStr = qtyString + " ";
            }
            try
            {
                using (SQLiteCommand sqlc = new SQLiteCommand("INSERT INTO sales(date,client,items,unit_p,qty,discount,coment) values(@date,@client,@items,@unit_p,@qty,@discount,@coment)", sqlCon))
                {
                    sqlc.Parameters.Add(new SQLiteParameter("@date") { Value = DateTime.Now });
                    sqlc.Parameters.Add(new SQLiteParameter("@client") { Value = clienTextBox.Text });
                    sqlc.Parameters.Add(new SQLiteParameter("@items") { Value = listId });
                    sqlc.Parameters.Add(new SQLiteParameter("@unit_p") { Value = pricesStr });
                    sqlc.Parameters.Add(new SQLiteParameter("@qty") { Value = qtyStr });
                    sqlc.Parameters.Add(new SQLiteParameter("@discount") { Value = disccountBox.Text });
                    sqlc.Parameters.Add(new SQLiteParameter("@coment") { Value = comentBox.Text });
                    sqlCon.Open();
                    sqlc.ExecuteNonQuery();
                    sqlCon.Close();

                };
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            shopList.Rows.Clear();
            clienTextBox.Text = "Mostrador";
            subTotalBox.Text = "";
            TotalBox.Text = "";
            comentBox.Text = null;
        }

        private void viewSales_Click(object sender, EventArgs e)
        {
            Form saleReceips = new saleReceips();
            saleReceips.ShowDialog();
        }

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerSelect pt = new printerSelect();
            pt.Show();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "backupdb.db"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "backupdb.db");
                    File.Copy(AppDomain.CurrentDomain.BaseDirectory + "data.db", AppDomain.CurrentDomain.BaseDirectory + "backupdb.db");
                }
                else
                {
                    File.Copy(AppDomain.CurrentDomain.BaseDirectory + "data.db", AppDomain.CurrentDomain.BaseDirectory + "backupdb.db");
                }
                debugStatusBar.Text = "Copia de seguridad creada correctamente.";
            }
            catch 
            {
                debugStatusBar.Text = "Error al realizar la copia de seguridad.";
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search_args = searchBoxInv.Text;
            Form search = new inv_Search(search_args);
            search.Show();
        }

        private void dataGridtab2_VisibleChanged(object sender, EventArgs e)
        {
            loadDB2();
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            loadDB();
        }
    }
}
