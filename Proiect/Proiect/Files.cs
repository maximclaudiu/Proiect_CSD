using System.Windows.Forms;
using System.IO;
using System;
using System.Linq;

namespace Proiect
{
    class Files
    {
        string fileContent;
        public void writeFileC(string text, string filename) {
            string location = Application.StartupPath;
            location = location.Substring(0, location.Length - 33) + "files\\Crypted_files";
            filename = filename.Substring(0, filename.Length - 4) + "_Crypted.txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(location, filename))) {
                    outputFile.WriteLine(text);
            }
        }
        public void writeFileD(string text, string filename) {
            string location = Application.StartupPath;
            location = location.Substring(0, location.Length - 33) + "files\\Decrypted_files";
            filename = filename.Substring(0, filename.Length - 4) + "_Decrypted.txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(location, filename))) {
                outputFile.WriteLine(text);
            }
        }
        public Tuple<string, string> openFile() {
            string location = Application.StartupPath;
            location = location.Substring(0, location.Length - 33) + "files";
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = location;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                    }
                }
                return Tuple.Create(fileContent, openFileDialog.FileName.Split('\\').Last());
            }
        }
        public static string BytetoString(byte[] array)
        {
            string cuvant = "";
            for (int i = 0; i < array.Length; i++) {
                cuvant = ($"{array[i]:X2}");
                if ((i % 4) == 3)
                    cuvant += " ";
            }
            return cuvant;
        }
    }
}
