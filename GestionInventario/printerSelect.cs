using System;
using System.Management;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class printerSelect : Form
    {
        public printerSelect()
        {
            InitializeComponent();
            var printerQuery = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
            foreach (var printer in printerQuery.Get()) 
            {
                var name = printer.GetPropertyValue("Name");
                printerList.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printerList.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una impresora.");
            }
            else 
            {
                Properties.Settings.Default.printer = printerList.SelectedItem.ToString();
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
