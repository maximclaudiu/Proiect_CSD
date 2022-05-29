
using System;
using System.Security.Cryptography;
using System.Text;

namespace Proiect
{
    class RSA {
        RSAParameters key;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        public void Initialize() {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            key = rsa.ExportParameters(true);
        }
        public byte[] Encrypt(string input) {
            byte[] toEncrypt = ByteConverter.GetBytes(input);
            byte[] encryptedData;
            try {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider()) {
                    RSA.ImportParameters(key);
                    encryptedData = RSA.Encrypt(toEncrypt, false);
                }
                return encryptedData;
            }
            catch (CryptographicException e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public string Decrypt(byte[] Data) {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider()) {
                    RSA.ImportParameters(key);
                    decryptedData = RSA.Decrypt(Data, false);
                }
                return new ASCIIEncoding().GetString(decryptedData);            
        }
        public string get_Key()
        {
            return key.D + " " + key.P;
        }
    }
}
