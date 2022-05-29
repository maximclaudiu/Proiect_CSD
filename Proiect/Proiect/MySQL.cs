using System;

namespace Proiect
{
    internal class MySQL
    {
        public string insert_Performance(int id, double c, double d)
        {
            return $"INSERT INTO table_performance(ID, Time_Crypt, Time_Decrypt) VALUES({id}, {c}, {d});";
        }
        public string insert_Keys(int id, string c, string d, Int32 l)
        {
            return $"INSERT INTO `keys`(ID, Crypt, Decrypt, Length) VALUES({id}, \'{c}\', \'{d}\', {l});";
        }
        public string insert_Algorithms(int id, string n, bool s) 
        {
            return $"INSERT INTO table_algorithm(ID, Name, Simetry) VALUES({id}, \"{n}\", {s});";
        }
        public string insert_Files(int id, string name, string hash, int alg, int key, int perf)
        {
            return $"INSERT INTO table_files(ID, Name, Hash, ID_Algorithm, Key_ID, ID_Performance) VALUES({id}, \'{name}\', \'{hash}\', {alg}, {key}, {perf});";
        }
        public string select_Last_ID(string table)
        {
            return $"SELECT * FROM `{table}` ORDER BY ID DESC LIMIT 1;";
        }

    }
}
