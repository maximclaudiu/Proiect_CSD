using System;
using System.Data;
using System.Diagnostics;
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
        string query = "";
        UInt16 choice = 0;
        byte[] crypted;
        double time_D,time_C;
        Stopwatch time = new Stopwatch ();
        Files files = new Files();
        MySQL sql = new MySQL();
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

        private void Select_B_Click(object sender, EventArgs e)
        {
            Execute_sql(sql.insert_Performance(0, time_C, time_D));
            //Execute_sql(sql.insert_Files(0, File_Name.Text, hash, alg, key, perf));
            //Execute_sql(sql.insert_Keys(0, aes.get_Key(), aes.get_Key(), aes.get_Key().Length));
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
            Save_metrics.Enabled = false;
            switch (choice) {
                case 1:
                    break;
                case 2: 
                    aes.Initialize();
                    time.Restart();
                    crypted = aes.Encrypt(Text_from_file.Text);
                    time.Stop();
                    Text_from_file.Text = System.Text.Encoding.UTF8.GetString(crypted);
                    files.writeFileC(Text_from_file.Text, "AES_"+File_Name.Text);
                    break;                    
                case 3:
                    des.Initialize();
                    time.Restart();
                    crypted = des.Encrypt(Text_from_file.Text);
                    time.Stop();
                    Text_from_file.Text = System.Text.Encoding.UTF8.GetString(crypted);
                    files.writeFileC(Text_from_file.Text, "DES_"+File_Name.Text);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
            time_C = time.ElapsedMilliseconds;
        }

        private void Decrypt_B_Click(object sender, EventArgs e) {
            Save_metrics.Enabled = true;
            switch (choice) {
                case 1:
                    break;
                case 2:
                    time.Restart();
                    Text_from_file.Text = aes.Decrypt(crypted);
                    time.Stop();
                    files.writeFileD(Text_from_file.Text, "AES_" + File_Name.Text);
                    break;
                case 3:
                    time.Restart();
                    Text_from_file.Text = des.Decrypt(crypted);
                    time.Stop();
                    files.writeFileD(Text_from_file.Text, "DES_" + File_Name.Text);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
            time_D = time.ElapsedMilliseconds;
        }
        public void Execute_sql(string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        
    }
}
