using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class query_consult
{
    static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
    SQLiteConnection sqlCon = new SQLiteConnection(urI);

    public void query_data(string id)
    {
        SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM local WHERE id = " + id,sqlCon);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        
    }
}

