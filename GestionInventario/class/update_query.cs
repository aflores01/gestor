using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

public class Update_query
{
    static readonly string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
    SQLiteConnection sqlCon = new SQLiteConnection(urI);

    public void UpdateDb(string p_aram, string b_ase, string v_al, string i_d) 
    {
        using (SQLiteCommand slqc = new SQLiteCommand("UPDATE " + b_ase + " SET " + p_aram + " = @Val WHERE id = @id", sqlCon))
        {
            sqlCon.Open();
            slqc.Parameters.Add(new SQLiteParameter("@id") { Value = i_d} );
            slqc.Parameters.Add(new SQLiteParameter("@Val") { Value = v_al  } );
            slqc.ExecuteNonQuery();
            sqlCon.Close();
        };
    }
}
