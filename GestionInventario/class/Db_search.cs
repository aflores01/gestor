using System;
using System.Data;
using System.Data.SQLite;

    class Db_search
    {
        private static string urI = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "/data.db";
        SQLiteConnection sqlCon = new SQLiteConnection(urI);

        public DataTable Search_query(string Query)
        {
            SQLiteDataAdapter adpt = new SQLiteDataAdapter(Query, sqlCon);
            DataTable dT = new DataTable();
            adpt.Fill(dT);
            return dT;
        }

        public void Execute_Query(string query)
        {
            using (SQLiteCommand slqc = new SQLiteCommand(query, sqlCon))
            {
                sqlCon.Open();
                slqc.ExecuteNonQuery();
                sqlCon.Close();
            };
        }
    }
