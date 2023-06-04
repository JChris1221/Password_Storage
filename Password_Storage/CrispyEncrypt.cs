using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace Password_Storage
{
    public class CrispyEncrypt
    {
        //takes 128 bit hex string and converts it to byte[16]
        private static byte[] HexStringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public string Decrypt(string enc_text, string key)
        {
            string iv = enc_text.Substring(0, 32);
            string text = enc_text.Substring(32);
            byte[] message = Convert.FromBase64String(text);

            SymmetricAlgorithm aes = Aes.Create();
            aes.KeySize = 128;
            aes.Key = HexStringToByteArray(key);
            aes.IV = HexStringToByteArray(iv);
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

        public string Decrypt(string enc_text, byte[] key)
        {
            string iv = enc_text.Substring(0, 32);
            string text = enc_text.Substring(32);
            byte[] message = Convert.FromBase64String(text);

            SymmetricAlgorithm aes = Aes.Create();
            aes.KeySize = 128;
            aes.Key = key;
            aes.IV = HexStringToByteArray(iv);
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


        public string Encrpyt(string message, string key)
        {
            byte[] byte_key = HexStringToByteArray(key);
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
        public string Encrpyt(string message, byte[] key)
        {
            byte[] byte_message = Encoding.ASCII.GetBytes(message);
            SymmetricAlgorithm aes = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            aes.BlockSize = 128;
            aes.Key = key;
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

        //
        public string CheckKey(string key)
        {
            if (key.Length < 32)
                return "Please enter 128 bit hex for the encryption key";
            return null;
        }

        public string CheckKey(byte[] key)
        {
            if(key.Length != 16)
                return "Please enter 128 bit hex for the encryption key";
            return null;
        }


        //Converts string to 128bit hash in string format
        public string HashString_HexString(string key)
        {
            byte[] hash_bytes = new byte[16];
            HashAlgorithm hash = MD5.Create();
            hash_bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(key));
            Console.WriteLine(ByteArrayToHexString(hash_bytes));
            return ByteArrayToHexString(hash_bytes);
        }

        //Converts string to 128bit hash
        public byte[] HashString(string key)
        {
            byte[] hash_bytes = new byte[16];
            HashAlgorithm hash = MD5.Create();
            hash_bytes = hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            return hash_bytes;
        }
    }
}
