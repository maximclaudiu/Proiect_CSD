using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;

namespace Proiect
{
    public partial class Form1 : Form {
        MySqlConnection con = new MySqlConnection (
            "server = localhost; userid = root; password =; database = csd_project"
            );
        MySqlCommand command;
        MySqlDataReader reader;
        string query = "select * from `keys`";
        UInt16 choice = 0;
        byte[] crypted;
        Files files = new Files(); 
        AES aes = new AES();
        DES des = new DES();

        public Form1() {
            InitializeComponent();
        }

        private void Connect_B_Click(object sender, EventArgs e) {

            if (con.State == ConnectionState.Closed)
                try {
                    con.Open();
                    Console.Text += "You are now connected\r\n";
                    command = con.CreateCommand();
                    command.Connection = con;
                    Connect_B.Text = "Disconnect";
                    Crypt_B.Enabled = true;
                    Decrypt_B.Enabled = true;
                }
                catch (Exception ex) {
                    Text_from_file.Text = ex.Message;
                }
            else {
                con.Close();
                Console.Text += "You are now disconnected\r\n";
                Connect_B.Text = "Connect";
                Crypt_B.Enabled = false;
                Decrypt_B.Enabled = false;
            }
        }

        private void Select_B_Click(object sender, EventArgs e) {
            if (con.State == ConnectionState.Open) {

                command.CommandText = query;
                reader = command.ExecuteReader();
                Text_from_file.Text = "";
                while (reader.Read()) {
                    int i = 0;
                    while (i < reader.FieldCount) {
                        Text_from_file.Text += reader[i].ToString() + " ";
                        i++;
                    }
                    Text_from_file.Text += "\r\n";
                }
                reader.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            choice = (ushort)(List_Crypto.Text[0] - 48);
        }

        private void Open_B_Click(object sender, EventArgs e) {
            var strings = files.openFile();
            Text_from_file.Text = strings.Item1;
            File_Name.Text = strings.Item2;
        }

        private void Crypt_B_Click(object sender, EventArgs e) {
            switch (choice) {
                case 1:
                    break;
                case 2: 
                    aes.Initialize();
                    crypted = aes.Encrypt(Text_from_file.Text);
                    Text_from_file.Text = System.Text.Encoding.UTF8.GetString(crypted);
                    files.writeFile(Text_from_file.Text, "AES"+File_Name.Text);
                    break;                    
                case 3:
                    des.Initialize();
                    crypted = des.Encrypt(Text_from_file.Text);
                    Text_from_file.Text = System.Text.Encoding.UTF8.GetString(crypted);
                    files.writeFile(Text_from_file.Text, "DES"+File_Name.Text);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;

            }
            
        }

        private void Decrypt_B_Click(object sender, EventArgs e) {
            switch (choice) {
                case 1:
                    break;
                case 2:                
                    Text_from_file.Text = aes.Decrypt(crypted);
                    files.writeFile(Text_from_file.Text, File_Name.Text);
                    break;
                case 3:                
                    Text_from_file.Text = des.Decrypt(crypted);
                    files.writeFile(Text_from_file.Text, File_Name.Text);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;

            }
        }
    }
}
