using System;
using Newtonsoft.Json;

namespace Password_Storage
{
    public class Account
    {
        public int id { get; set; }
        public string account_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime date_saved { get; set; }

        public Account(string _username, string _password)
        {
            this.username = _username;
            this.password = _password;
        }

        [JsonConstructor]
        public Account(int _id, string _account_name, string _username, string _password, DateTime _date_saved)
        {
            this.id = _id;
            this.account_name = _account_name;
            this.username = _username;
            this.password = _password;
            this.date_saved = _date_saved;
        }

        public Account()
        {
            this.account_name = "";
            this.username = "";
            this.password = "";
            this.date_saved = DateTime.Now;
        }
       
        public void UpdateAccount(string _account_name, string _username, string _password)
        {
            this.account_name = _account_name;
            this.username = _username;
            this.password = _password;
        }

        public void UpdateAccount(Account _account)
        {
            this.account_name = _account.account_name;
            this.username = _account.username;
            this.password = _account.password;
        }
    }
}
