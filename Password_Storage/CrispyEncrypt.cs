using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace Password_Storage
{
    public static class CrispyEncrypt
    {
        static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static string Decrypt(string enc_text, string key)
        {
            string iv = enc_text.Substring(0, 32);
            string text = enc_text.Substring(32);
            byte[] message = Convert.FromBase64String(text);

            SymmetricAlgorithm aes = Aes.Create();
            aes.KeySize = 128;
            aes.Key = StringToByteArray(key);
            aes.IV = StringToByteArray(iv);
            using (MemoryStream ms = new MemoryStream(message))
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[message.Length];
                    cs.Read(decryptedBytes, 0, decryptedBytes.Length);
                    return Encoding.ASCII.GetString(decryptedBytes);
                }
            }
        }


        public static string Encrpyt(string message, string key)
        {
            byte[] byte_key = StringToByteArray(key);
            byte[] byte_message = Encoding.ASCII.GetBytes(message);
            SymmetricAlgorithm aes = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            aes.BlockSize = 128;
            aes.Key = byte_key;
            aes.IV = hash.ComputeHash(Encoding.ASCII.GetBytes(DateTime.Now.ToString()));

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(byte_message, 0, byte_message.Length);
                    }

                    string encrypted = Convert.ToBase64String(ms.ToArray());
                    string iv_string = ByteArrayToHexString(aes.IV);

                    return iv_string + encrypted;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }
        public static string check_key(string key)
        {
            if (key.Length < 32)
                return "Please enter 128 bit hex for the encryption key";
            return null;

        }
    }
}
