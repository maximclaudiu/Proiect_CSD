using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Proiect
{
    public class DES
    {
        private byte[] Key;
        private byte[] IV;
        public void Initialize() {
            System.Security.Cryptography.DES DESalg = System.Security.Cryptography.DES.Create();
            Key = DESalg.Key;
            IV = DESalg.IV;
        }
        public byte[] Encrypt(string Data) {
            try {    
                MemoryStream mStream = new MemoryStream();
                System.Security.Cryptography.DES DESalg = System.Security.Cryptography.DES.Create();
                CryptoStream cStream = new CryptoStream(mStream,
                    DESalg.CreateEncryptor(Key, IV),
                    CryptoStreamMode.Write);

                byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();
                byte[] ret = mStream.ToArray();

                cStream.Close();
                mStream.Close();

                return ret;
            }
            catch (CryptographicException e) {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
        public string Decrypt(byte[] Data) {
            try {
                MemoryStream msDecrypt = new MemoryStream(Data);
                System.Security.Cryptography.DES DESalg = System.Security.Cryptography.DES.Create();

                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    DESalg.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);

                byte[] fromEncrypt = new byte[Data.Length];

                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                return new ASCIIEncoding().GetString(fromEncrypt);
            }
            catch (CryptographicException e) {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
        public string get_Key() {
            return Files.BytetoString(Key);
        }
    }
}
