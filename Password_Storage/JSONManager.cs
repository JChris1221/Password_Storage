using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Password_Storage
{
    public static class JSONManager
    {
        public static List<Account> LoadJson(string path)
        {
            List<Account> accounts = new List<Account>();
            
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
                return accounts;
            }
        }

        //Saves file. If no file exist a new file is created;
        public static bool SaveJSON(string filename, List<Account> accounts)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "yyyy-MM-dd";
            settings.Formatting = Formatting.Indented;
            File.WriteAllText(filename, JsonConvert.SerializeObject(accounts, settings));
            return true;
        }
    }
}
