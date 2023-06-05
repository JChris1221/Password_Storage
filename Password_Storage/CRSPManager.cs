using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Password_Storage
{
    public static class CRSPManager
    {
        public static List<Account> LoadCRSP(string path, byte[] key)
        {
            List<Account> accounts = new List<Account>();
            
            using (StreamReader r = new StreamReader(path))
            {
                CrispyEncrypt ce = new CrispyEncrypt();
                
                byte[] crsp_bytes = Encoding.ASCII.GetBytes(r.ReadToEnd());
                try
                {
                    string crsp = Encoding.ASCII.GetString(ce.Decrypt(crsp_bytes, key));
                    accounts = JsonConvert.DeserializeObject<List<Account>>(crsp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                    
                return accounts;
            }
        }

        //Saves file. If no file exist a new file is created;
        public static bool SaveCRSP(string filename, List<Account> accounts, byte[] key)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "yyyy-MM-dd";
            settings.Formatting = Formatting.Indented;

            CrispyEncrypt ce = new CrispyEncrypt();
            byte[] json_bytes = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(accounts, settings));
            byte[] encrypted_json = ce.Encrypt(json_bytes, key);

            File.WriteAllText(filename, Encoding.ASCII.GetString(encrypted_json));
            return true;
        }
    }
}
