using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

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
        string fileContent;
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
                    Text_from_files.Text = ex.Message;
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
                Text_from_files.Text = "";
                while (reader.Read()) {
                    int i = 0;
                    while (i < reader.FieldCount) {
                        Text_from_files.Text += reader[i].ToString() + " ";
                        i++;
                    }
                    Text_from_files.Text += "\r\n";
                }
                reader.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            choice = (ushort)(List_Crypto.Text[0] - 48);
        }

        private void Open_B_Click(object sender, EventArgs e) {
            string location = Application.StartupPath;
            location = location.Substring(0, location.Length - 25);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = location;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                        Text_from_files.Text = fileContent;
                        Text_from_file.Text = openFileDialog.FileName.Split('\\').Last();
                    }
                }
            }
        }

        private void Crypt_B_Click(object sender, EventArgs e) {
            switch (choice) {
                case 1:
                    break;
                case 2: {
                        AES aes = new AES();
                        aes.Initialize();
                        string encrypt = System.Text.Encoding.UTF8.GetString(aes.Encrypt(fileContent));
                        Text_from_files.Text = encrypt;
                        break;
                    }
                case 3:
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
                case 2: {
                        AES aes = new AES();
                        aes.Initialize();
                        string encrypt = aes.Decrypt(aes.Encrypt(fileContent));
                        Text_from_files.Text = encrypt;
                        break;
                    }
                case 3:
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
