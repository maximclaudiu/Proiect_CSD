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
            filename = filename.Substring(0, filename.Length - 4) + "_Crypted.txt";
            File.WriteAllTextAsync(filename, text);
        }
        public void writeFileD(string text, string filename)
        {
            filename = filename.Substring(0, filename.Length - 4) + "_Decrypted.txt";
            File.WriteAllTextAsync(filename, text);
        }
        public Tuple<string, string> openFile() {
            string location = Application.StartupPath;
            location = location.Substring(0, location.Length - 33) + "files";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = location;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                    }
                }
                return Tuple.Create(fileContent, openFileDialog.FileName.Split('\\').Last());
            }
        }
    }
}
