using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using OpenHtmlToPdf;
using System.Diagnostics;

namespace GestionInventario
{
    public partial class saleReceips : Form
    {
        static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
        static readonly string ruta = AppDomain.CurrentDomain.BaseDirectory;
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

        private void searchReceip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(folioTextBox.Text)) 
            {
                MessageBox.Show("Introduzca un folio.");
            }
            else
            {
                sqlCon.Open();
                SQLiteDataAdapter result = new SQLiteDataAdapter("SELECT * FROM sales WHERE id = " + folioTextBox.Text, sqlCon);
                DataTable dt = new DataTable();
                result.Fill(dt);
                receipsGridView.DataSource = dt;
                DataGridViewButtonColumn dvb = new DataGridViewButtonColumn() 
                {
                    Name = "Descargar",
                    HeaderText = "Descargar",
                    UseColumnTextForButtonValue = true,
                    Text = "PDF"
                };
                if (receipsGridView.Columns["Descargar"] == null)
                {
                    receipsGridView.Columns.Insert(0, dvb);
                }
                receipsGridView.CellClick += ReceipsGridView_CellClick;
                sqlCon.Close();
            }
        }

        private void ReceipsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const string html = "<!DOCTYPE html>" +
            "<html>" +
            "<head><meta charset='UTF-8'><title>Title</title></head>" +
            "<body>Body text...</body>" +
            "</html>";
            var pdf = Pdf.From(html).Content();
            FileStream fs = new FileStream(ruta + "/data.pdf", FileMode.Create,FileAccess.Write);
            fs.Write(pdf, 0, pdf.Length);
            fs.Close();
            Process.Start(ruta + "/data.pdf");
        }
    }
}
