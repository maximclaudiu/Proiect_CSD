using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class MySQL
    {
        public string insert_Keys(int id, string c, string d, int l)
        {
            return "INSERT INTO keys(ID,Crypt,Decrypt,Length) VALUES("
                + id + ',' + "\'" + c + "\'" + ',' + "\'" + d + "\'" + ',' + l + ");";
        }
        public string insert_Algorithms(int id, string n, bool s)
        {
            return "INSERT INTO table_algorithm(ID,Name,Simetry) VALUES("
                + id + ',' + "\'" + n + "\'" + ',' + s + ");";
        }
        public string insert_Files(string data)
        {
            return "INSERT INTO table_files" ;
        }
        public string insert_Performance(int id, double c, double d)
        {
            return "INSERT INTO table_performance(ID, Time_Crypt, Time_Decrypt) VALUES("
                + id + ',' + c + ',' + d + ");";
        }

    }
}
