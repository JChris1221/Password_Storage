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
        public int current_id { get; set; }
        public AccountForm()
        {
            InitializeComponent();
        }

        private void save_account_btn_Click(object sender, EventArgs e)
        {
            account = new Account(current_id, acc_name_tb.Text, username_tb.Text, password_tb.Text, DateTime.Now);
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
