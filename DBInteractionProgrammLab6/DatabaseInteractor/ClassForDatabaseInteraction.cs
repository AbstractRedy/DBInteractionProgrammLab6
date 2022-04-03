using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using DatabaseInteractor;

namespace CFDT
{
    public class DatabaseInteraction
    {
        //CURRENT LIBRARY SUPPORTS ONLY ELEMENTS MANAGEMENT, I DONT CARE ABOUT TABLES NAMES
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        private Dictionary<string, string[]> columns;
        private string[] tables;
        public DatabaseInteraction(string database, string password)
        {
            //string database = "учавтоорганизации"; //ломбард, учавтоорганизации, инфосистемабиблгорода
            //string password = "";
            connection = new MySqlConnection(
                "Server=" + "127.0.0.1" + ";" +
                "Database=" + database + ";" +
                "port=" + "3306" + ";" +
                "User Id=" + "root" + ";" +
                "password=" + password
                );
            connection.Open();
            cmd = new MySqlCommand("SHOW TABLES", connection);
            reader = cmd.ExecuteReader();

            List<string> list = new List<string>(); //Переработать
            while (reader.Read()) list.Add(reader.GetString(0));
            tables = list.ToArray();

            reader.Close();
            ColumnsConfigure();
        }
        private void ColumnsConfigure()
        {
            columns = new Dictionary<string, string[]>();
            foreach(var table in tables)
            {
                cmd.CommandText = "SHOW FIELDS FROM `" + table + "`";
                reader = cmd.ExecuteReader();
                
                List<string> list = new List<string>(); //Переработать
                while (reader.Read())
                    list.Add(reader.GetString(0));
                columns.Add(table, list.ToArray());

                reader.Close();
            }
        }
        public void AddToTable(string table, string arguments)
        {
            if (!tables.Contains(table))
                return;
            string[] columns = Columns(table);
            string command = 
                "INSERT INTO `" + table + "` (`" +
                String.Join("`, `", columns.Skip(1))
                + "`) VALUES (" +
                arguments + ")";
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
        public void RemoveFromTable(string table, string condition)
        {
            if (!tables.Contains(table))
                return;
            string command = 
                "DELETE FROM `" + table + 
                "` WHERE " + condition;
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
        public void UpdateElement(string table, string update, string condition)
        {
            if (!tables.Contains(table))
                return;
            string command = 
                "UPDATE `" + table +
                "` SET " + update +
                " WHERE " + condition;
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
        public string[,] ShowElements(string table)
        {
            if (tables.Contains(table))
            {
                string cmd = "SELECT * FROM `" + table + "`";
                return ElementsFinder(cmd, table);
            }
            else
                return null;
        }
        public string[,] ShowElements(string table, string condition)
        {
            if (tables.Contains(table))
            {
                string cmd = "SELECT * FROM `" + table + "` " + condition;
                return ElementsFinder(cmd, table);
            }
            else
                return null;
        }
        private string[,] ElementsFinder(string command, string table)
        {
            int countercolumns = Columns(table).Length;
            int counterrows = 0;
            cmd.CommandText = command;
            reader = cmd.ExecuteReader();
            while (reader.Read()) 
                counterrows++;
            reader.Close();
            string[,] elements
                = new string[countercolumns, counterrows];
            reader = cmd.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
                for (int j = 0; j < elements.GetLength(0); j++)
                    elements[j, i] = reader.GetValue(j).ToString();
            reader.Close();
            return elements;
        }
        public string[] Tables
        { get { return tables; } }
        public string[] Columns(string table) 
            => tables.Contains(table)? columns[table] :null;

        //METHODS ONLY FOR CONSOLE, DO NOT USE THEM IN WINDOWS FORMS OR WPF YOU DUMBASS
        public void PrintElements(string[,] array, string[] columns)
        {
            int[] spaces = new int[columns.Length];
            int l = 0;
            foreach (var a in columns)
            {
                Console.Write(a + "      ");
                spaces[l] = a.Length + 1;
                l++;
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[j, i] + "     ");
                    for (int k = 0; k < spaces[j] - array[j, i].Length; k++)
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        public void PrintTables()
        {
            foreach (var a in Tables) Console.WriteLine(a);
        }
    }
}
