using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailprofilerTestApp
{
    class Singleton
    {
        private static Singleton instance = null;
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestDatabase.accdb");
        public BindingList<Vyrobek> Data = new BindingList<Vyrobek>();
        private Singleton() { }

        public static Singleton Instance {
            get {
                if (instance == null) {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        /// <summary>
        /// hjkh
        /// hkhj
        /// </summary>
        /// <returns>1234</returns>
        internal DataSet DisplayData()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from Výrobek", connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "vyrobky");
            return ds;
        }

        /// <summary>
        /// 
        /// </summary>
        internal void LoadProductsFromDatabaze()
        {
            
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from Výrobek", connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "vyrobky");
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                
                Data.Add(new Vyrobek(dr["ID"].ToString(), dr["Nazev"].ToString(), dr["Popis"].ToString(), 
                    dr["Poznamka"].ToString(), dr["Cena"].ToString(), dr["Zalozeno"].ToString(),
                    dr["Upraveno"].ToString(), LoadNumOfParts(dr["ID"].ToString())));
            }
            
        }

        private string LoadNumOfParts(string id)
        {
            string result = null ;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Díl WHERE VyrobekID = "+id+";", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetValue(0).ToString();
                    // Insert code to process data.
            }
            reader.Close();
            return result;
        }

        internal void DeleteProductsFromDatabase(string id)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Výrobek WHERE ID = " + id + ";", connection);
            cmd.ExecuteNonQuery();
            Data.Remove(Data.SingleOrDefault(v => v.ID == id));

        }

        internal void InsertIntoDatabaze(string name, string description, string note, decimal price)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Výrobek (Nazev, Popis, Poznamka, Cena, Zalozeno) "
            + "VALUES(@Nazev, @Popis, @Poznamka, @Cena, @Zalozeno);", connection);
            cmd.Parameters.AddWithValue("@Nazev", name);
            cmd.Parameters.AddWithValue("@Popis", description);
            cmd.Parameters.AddWithValue("@Poznamka", note);
            cmd.Parameters.AddWithValue("@Cena", price.ToString());
            cmd.Parameters.AddWithValue("@Zalozeno", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            cmd.ExecuteNonQuery();
            int lastID = 0;
            using (OleDbCommand command = new OleDbCommand("SELECT @@IDENTITY;", connection))
            {
                lastID = (int)command.ExecuteScalar();
            }
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM Výrobek WHERE ID = "+lastID+";", connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "vyrobek");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Data.Add(new Vyrobek(dr["ID"].ToString(), dr["Nazev"].ToString(), dr["Popis"].ToString(),
                    dr["Poznamka"].ToString(), dr["Cena"].ToString(), DateTime.Parse(dr["Zalozeno"].ToString().Split(' ')[0]).ToString("dd.MM.yyyy HH:mm:ss"),
                    dr["Upraveno"].ToString(), "0"));
            }

        }

        internal void UpdateProductsData(string id, string name, string description, string note, decimal price)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            cmd.CommandText = "UPDATE Výrobek SET Nazev = '"+name+"', Popis = '"+description+"', "
                +"Poznamka = '"+note+"', Cena = "+price+", Upraveno = '"+DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") +"' WHERE ID = "+id+";";
            cmd.ExecuteNonQuery();
            Data.SingleOrDefault(v => v.ID == id).Nazev = name;
            Data.SingleOrDefault(v => v.ID == id).Popis = description;
            Data.SingleOrDefault(v => v.ID == id).Poznamka = note;
            Data.SingleOrDefault(v => v.ID == id).Cena = price.ToString();
            Data.SingleOrDefault(v => v.ID == id).Upraveno = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }


}
