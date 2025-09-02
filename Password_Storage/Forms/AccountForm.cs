using Password_Storage.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Storage
{
    public partial class AccountForm : Form
    {
        public Account account { get; set; }
        //public int current_id { get; set; }
        public AccountForm()
        {
            InitializeComponent();
        }

        public AccountForm(Account _account)
        {
            InitializeComponent();
            account = _account;
            this.acc_name_tb.Text = this.account.account_name;
            this.username_tb.Text = this.account.username;
            this.password_tb.Text = this.account.password;
        }

        private void save_account_btn_Click(object sender, EventArgs e)
        {
            //account = new Account(account.id, acc_name_tb.Text, username_tb.Text, password_tb.Text, DateTime.Now);
            account.account_name = acc_name_tb.Text;
            account.username = username_tb.Text;
            account.password = password_tb.Text;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
