using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Text;

namespace Password_Storage
{
    public partial class Main_Form : Form
    {
        private List<Account> accounts;
        private BindingList<Account> accounts_bl;
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
            enter_password_form enter_password = new enter_password_form();
            enter_password.crispy_encrypt = this.crispy_encrypt;

            if (load_json.ShowDialog() == DialogResult.OK)
            {
                if (enter_password.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_password.key;
                    Debug.Write(Encoding.ASCII.GetString(this.key));
                    current_file = load_json.FileName;
                    accounts = CRSPManager.LoadCRSP(current_file, this.key);

                    if (accounts == null)
                    {
                        MessageBox.Show("Invalid key", "Decryption Failed", MessageBoxButtons.OK);
                    }
                    else
                    {
                        filename_lbl.Text = "Current File: " + current_file;
                        save_btn.Enabled = true;
                        accounts_bl = new BindingList<Account>(accounts);
                        accounts_cb.DataSource = accounts_bl;
                        accounts_cb.Enabled = true;
                    }
                }
            }
        }

        private void accounts_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selected = accounts.Single(a => a.id == (int)accounts_cb.SelectedValue);
            username_lbl.Text = selected.username;
            password_lbl.Text = selected.password;
            date_saved_tb.Text = selected.date_saved.ToString("dddd, dd MMMM yyyy");
        }

        private void add_account_btn_Click(object sender, EventArgs e)
        {
            AddAccount_Form add_form = new AddAccount_Form();
            if (accounts == null)
                add_form.current_id = 0;
            else
                add_form.current_id = accounts.Last().id + 1;



            if (add_form.ShowDialog() == DialogResult.OK)
            {

                if (accounts == null)
                    accounts = new List<Account>();

                Account account = add_form.account;
                accounts.Add(account);
                accounts_bl = new BindingList<Account>(accounts);
                accounts_cb.DataSource = accounts_bl;


                if (!accounts_cb.Enabled)
                    accounts_cb.Enabled = true;
                if (!save_btn.Enabled)
                    save_btn.Enabled = true;
            }

        }

        private void save_btn_Click(Object sender, EventArgs e)
        {
            SaveFileDialog save_form = new SaveFileDialog();
            save_form.Title = "Save CSRP";
            save_form.Filter = "crispy encrypt files (*.crsp)|*.crsp";
            save_form.DefaultExt = "crsp";
            save_form.CheckPathExists = true;
            //save_form.CheckFileExists = true;

            if (current_file == "" || current_file == null)
            {
                if (save_form.ShowDialog() == DialogResult.OK)
                {
                    enter_password_form enter_pass = new enter_password_form();
                    enter_pass.crispy_encrypt = this.crispy_encrypt;
                    if (enter_pass.ShowDialog() == DialogResult.OK)
                    {
                        this.key = enter_pass.key;
                        Debug.Write(Encoding.ASCII.GetString(this.key));
                        this.current_file = save_form.FileName;
                    }
                }
            }
            else
                CRSPManager.SaveCRSP(current_file, accounts, this.key);
        }

    }

}
