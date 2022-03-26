using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proiect
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(
            "server = localhost; userid = root; password =; database = csd_project"
            );
        MySqlCommand command;
        MySqlDataReader reader;
        string query = "select * from `keys`";
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_B_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                try {
                    con.Open();
                    textBox1.Text = "You are now connected";
                    command = con.CreateCommand();
                    command.Connection = con;
                }
                catch (Exception ex) {
                    textBox1.Text = ex.Message;
                }
            else {
                con.Close();
                textBox1.Text = "You are now disconnected";
            }

        }

        private void Select_B_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                
                command.CommandText = query;
                reader = command.ExecuteReader();
                textBox1.Text = "";
                while (reader.Read())
                {
                    int i = 0;
                    while ( i <reader.FieldCount)
                    { 
                        textBox1.Text += reader[i].ToString()+ " ";
                        i++;
                    }
                    textBox1.Text += "\r\n";
                }
                reader.Close();
            }
        }
    }
}
