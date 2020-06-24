using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class contact_number : Form
    {
        private string default_contact = Properties.Settings.Default.contact_number.ToString();
        public contact_number()
        {
            InitializeComponent();
            contact_edit.Text = default_contact;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (contact_edit.Text == null)
            {
                MessageBox.Show("Debe ingresar un número de contacto.");
            }
            else {
                Properties.Settings.Default.contact_number = contact_edit.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void contact_edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter) 
            {
                if (contact_edit.Text == null)
                {
                    MessageBox.Show("Debe ingresar un número de contacto.");
                }
                else
                {
                    Properties.Settings.Default.contact_number = contact_edit.Text;
                    Properties.Settings.Default.Save();
                    this.Close();
                }
            }
        }
    }
}
