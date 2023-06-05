using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
//using Newtonsoft.Json;
//using System.IO;

namespace Password_Storage
{
    public partial class Main_Form : Form
    {
        private List<Account> accounts;
        private byte[] key;
        private string current_file;
        private CrispyEncrypt crispy_encrypt;
        public Main_Form()
        {
            InitializeComponent();
            crispy_encrypt = new CrispyEncrypt();
        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_json = new OpenFileDialog();
            EnterPassword_Form enter_password = new EnterPassword_Form();
            enter_password.crispy_encrypt = this.crispy_encrypt;

            if (load_json.ShowDialog() == DialogResult.OK)
            {
                if (enter_password.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_password.key;
                    current_file = load_json.FileName;
                    filename_lbl.Text = "Current File: " + current_file;
                    CRSPManager.LoadCRSP(current_file, key);
                }
            }
        }

        private void accounts_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selected = accounts.Single(a => a.id == (int)accounts_cb.SelectedValue);
            //try
            //{
            //    username_lbl.Text = crispy_encrypt.Decrypt(selected.username, key);
            //    password_lbl.Text = crispy_encrypt.Decrypt(selected.password, key);
            //    date_saved_tb.Text = selected.date_saved.ToString("dddd, dd MMMM yyyy");
            //}
            //catch (CryptographicException ce)
            //{
            //    MessageBox.Show(ce.Message, "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    current_file = "";
            //    filename_lbl.Text = "No File Selected";
            //    accounts_cb.Enabled = false;
            //    accounts_cb.DataSource = null;
            //    accounts_cb.Text = "";
            //}
        }

        private void add_account_btn_Click(object sender, EventArgs e)
        {
            AddAccount_Form add_form = new AddAccount_Form();
            if (accounts.Count > 0)
            {
                add_form.current_id = accounts.Last().id + 1;
                if (add_form.ShowDialog() == DialogResult.OK)
                {
                    Account account = add_form.account;
                    //CrispyEncrypt ce = new CrispyEncrypt();
                    //account.username = crispy_encrypt.Encrpyt(account.username, key);
                    //account.password = crispy_encrypt.Encrpyt(account.password, key);
                    accounts.Add(account);

                    //Save JSON
                    //if (CRSPManager.SaveJSON(current_file, accounts))
                    //{
                    //    //Reload JSON
                    //    CRSPManager.LoadJson(current_file);
                    //    MessageBox.Show("Account Added");
                    //}
                }
            }
        }

        private void save_file_btn_Click(Object sender, EventArgs e)
        {
            CRSPManager.SaveCRSP(current_file, accounts, this.key);
        }

    }

}
