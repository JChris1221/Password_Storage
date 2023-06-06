using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Password_Storage
{
    public static class CRSPManager
    {
        public static List<Account> LoadCRSP(string filename, byte[] key)
        {
            CrispyEncrypt ce = new CrispyEncrypt();

            byte[] crsp_bytes = File.ReadAllBytes(filename);
            try
            {
                string crsp = Encoding.ASCII.GetString(ce.Decrypt(crsp_bytes, key));
                return JsonConvert.DeserializeObject<List<Account>>(crsp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
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

            File.WriteAllBytes(filename, encrypted_json);
            return true;
        }
    }
}
