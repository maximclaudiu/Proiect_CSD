using System.IO;
using System.Security.Cryptography;

namespace Proiect
{
    public class AES
    {
        private byte[] Key;
        private byte[] IV;
        public void Initialize()
        {
            AesManaged aes = new AesManaged();
            Key = aes.Key;
            IV = aes.IV;
        }
        public byte[] Encrypt(string plainText) {
            byte[] encrypted;
            AesManaged aes = new AesManaged();
            aes.Padding = PaddingMode.PKCS7;
            ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
            using (MemoryStream ms = new MemoryStream()) {
                  
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                        sw.Write(plainText);
                    encrypted = ms.ToArray();
                }               
            }
            return encrypted;
        }
        public string Decrypt(byte[] cipherText)
        {
            string plaintext = null;
            using (AesManaged aes = new AesManaged())
            {
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }
        public string get_Key() {
            return Files.BytetoString(Key);
        }
    }
}
