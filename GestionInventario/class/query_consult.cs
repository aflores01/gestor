using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class query_consult
{
    static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
    SQLiteConnection sqlCon = new SQLiteConnection(urI);

    public void query_data(string id)
    {
        DialogResult r_esult = MessageBox.Show("Confirmar entrega", "Confirmar", MessageBoxButtons.YesNo);
        if (r_esult == DialogResult.Yes)
        {
            var update = new Update_query();
            update.UpdateDb("entregado","local","0",id);
        }
        else { }
    }
}

