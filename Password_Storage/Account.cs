using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //public bool AddAccount(Account account)
        //{
        //    //Encrypt username and password

        //    return true;
        //}
        //Create method which returns account array/list 'GetAccounts(JSON FILE)
    }
}
