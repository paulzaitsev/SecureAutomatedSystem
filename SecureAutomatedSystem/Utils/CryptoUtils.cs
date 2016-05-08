using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureAutomatedSystem.Utils {
    public static class CryptoUtils {
        public static string GetMd5Hash(string input) {
            StringBuilder sBuilder = new StringBuilder();
            using (MD5 md5Hash = MD5.Create()) {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                for (int i = 0; i < data.Length; i++) {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }
            return sBuilder.ToString();
        }

        private static DES desEncryptor;

        public static DES DesEncryptor {
            get {
                if (desEncryptor == null) {
                    desEncryptor = DES.Create();
                    desEncryptor.Mode = CipherMode.ECB;
                }
                return desEncryptor;
            }
        }

        public static string EncryptParameter(float parameter, string key) {
            DesEncryptor.Key = Encoding.UTF8.GetBytes(key);
            using (MemoryStream msEncrypt = new MemoryStream()) {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, DesEncryptor.CreateEncryptor(DesEncryptor. Key, DesEncryptor. IV), CryptoStreamMode.Write)) {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                        swEncrypt.Write(parameter);
                    }
                    return Encoding.UTF8.GetString(msEncrypt.ToArray());
                }
            }
        }

        public static string DecryptParameter(string parameter, string key) {
            DesEncryptor.Key = Encoding.UTF8.GetBytes(key);
            using (MemoryStream msDecrypt = new MemoryStream()) {
                using ( CryptoStream csDecrypt = new CryptoStream(msDecrypt, DesEncryptor.CreateDecryptor(DesEncryptor.Key, DesEncryptor.IV), CryptoStreamMode.Read)) {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt)) {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
