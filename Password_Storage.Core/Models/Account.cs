using System;
using Newtonsoft.Json;

namespace Password_Storage.Core.Models
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
            username = _username;
            password = _password;
        }

        [JsonConstructor]
        public Account(int _id, string _account_name, string _username, string _password, DateTime _date_saved)
        {
            id = _id;
            account_name = _account_name;
            username = _username;
            password = _password;
            date_saved = _date_saved;
        }

        public Account()
        {
            account_name = "";
            username = "";
            password = "";
            date_saved = DateTime.Now;
        }
       
        public void UpdateAccount(string _account_name, string _username, string _password)
        {
            account_name = _account_name;
            username = _username;
            password = _password;
        }

        public void UpdateAccount(Account _account)
        {
            account_name = _account.account_name;
            username = _account.username;
            password = _account.password;
        }
    }
}
