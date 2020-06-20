using System;
using System.Data;
using System.Data.SQLite;

    class Db_search
    {
        public DataTable Search_query(string Query)
        {
            string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
            SQLiteConnection sqlCon = new SQLiteConnection(urI);
            SQLiteDataAdapter adpt = new SQLiteDataAdapter(Query, sqlCon);
            DataTable dT = new DataTable();
            adpt.Fill(dT);
            return dT;
        }
    }
