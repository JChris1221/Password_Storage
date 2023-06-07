using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;


// This class manages serialization and deserialization crsp files as well managing the accounts list stored inside

namespace Password_Storage
{
    public class CRSPManager
    {
        CrispyEncrypt encryptor;
        List<Account> accounts;

        public CrispyEncrypt Encryptor { 
            get{ return this.encryptor; } 
        }

        public List<Account> Accounts { 
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public CRSPManager()
        {
            this.accounts = new List<Account>();
            this.encryptor = new CrispyEncrypt();
        }

        public CRSPManager(List<Account> _accounts)
        {
            this.accounts = _accounts;
            this.encryptor = new CrispyEncrypt();
        }
        public List<Account> LoadCRSP(string filename, byte[] key)
        {

            byte[] crsp_bytes = File.ReadAllBytes(filename);
            try
            {
                string crsp = Encoding.ASCII.GetString(encryptor.Decrypt(crsp_bytes, key));
                return JsonConvert.DeserializeObject<List<Account>>(crsp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Saves file. If no file exist a new file is created;
        public bool SaveCRSP(string filename, List<Account> accounts, byte[] key)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "yyyy-MM-dd";
            settings.Formatting = Formatting.Indented;

            byte[] json_bytes = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(accounts, settings));
            byte[] encrypted_json = encryptor.Encrypt(json_bytes, key);

            File.WriteAllBytes(filename, encrypted_json);
            return true;
        }

        public bool Update(Account _account)
        {
            accounts.Single(x => x.id == _account.id).UpdateAccount(_account);
            return true;
        }

        public bool Delete(Account _account)
        {
            accounts.Remove(_account);
            return true;
        }

        public bool Delete(int id)
        {
            accounts.Remove(accounts.Single(r => r.id == id));
            return true;
        }

        public bool Add(Account _account)
        {
            int id;
            if (accounts.Count > 0)
                id = accounts.OrderBy(o => o.id).ToList().Last().id + 1;
            else
                id = 0;

            _account.id = id;
            accounts.Add(_account);
            return true;
        }

        public Account Get(int id)
        {
            return accounts.SingleOrDefault(x => x.id == id);
        }
    }
}
