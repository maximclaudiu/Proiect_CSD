using System;
using System.Text;
using System.Security.Cryptography;

namespace Proiect
{
    class SHA_256 {
        static SHA256 mysha256;
        public void Init() {
            mysha256 = SHA256.Create();
        }
        public string GetHash(string input) {
            HashAlgorithm hashAlgorithm = mysha256;
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        private bool VerifyHash(string input, string hash) {
            var hashOfInput = GetHash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
