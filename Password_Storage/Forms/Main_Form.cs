using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Text;
using System.Drawing.Design;
using Password_Storage.Core.Models;
using Password_Storage.Core.Utilities;
using Password_Storage.Core.Interfaces.Utilities;

namespace Password_Storage
{
    public partial class Main_Form : Form
    {
        private ICRSPManager crsp_manager;
        private BindingList<Account> accounts_bl;
        private byte[] key;
        private string current_file;
        
        public Main_Form()
        {
            InitializeComponent();
            crsp_manager = new CRSPManager();
        }
        private void open_btn_Click(object sender, EventArgs e)
        {
            EnterPasswordForm enter_password = new EnterPasswordForm();
            enter_password.crispy_encrypt = crsp_manager.Encryptor;

            if (open_crsp_dialog.ShowDialog() == DialogResult.OK)
            {
                if (enter_password.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_password.key; //May need to be hashed
                    current_file = open_crsp_dialog.FileName;
                    OpenCRSP();
                }
            }
        }

        private void save_btn_Click(Object sender, EventArgs e)
        {
            if(crsp_manager.Save(current_file, crsp_manager.Accounts, this.key))
                OpenCRSP();
        }

        private void save_as_btn_Click(Object sender, EventArgs e)
        {
            if (save_crsp_dialog.ShowDialog() == DialogResult.OK)
            {
                EnterPasswordForm enter_pass = new EnterPasswordForm();
                enter_pass.crispy_encrypt = crsp_manager.Encryptor;
                if (enter_pass.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_pass.key;
                    this.current_file = save_crsp_dialog.FileName;
                    crsp_manager.Save(current_file, crsp_manager.Accounts, this.key);
                }

            }
            OpenCRSP();

        }

        private void accounts_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selected = crsp_manager.Accounts.Single(a => a.id == (int)accounts_cb.SelectedValue);
            username_lbl.Text = selected.username;
            password_lbl.Text = selected.password;
            date_saved_tb.Text = selected.date_saved.ToString("dddd, dd MMMM yyyy");
        }

        private void add_account_btn_Click(object sender, EventArgs e)
        {
            AccountForm add_account = new AccountForm(new Account());
            add_account.Text = "Add Account";

            if (add_account.ShowDialog() == DialogResult.OK)
            {
                Account account = add_account.account;
                crsp_manager.Add(account);
                accounts_bl = new BindingList<Account>(crsp_manager.Accounts);
                accounts_cb.DataSource = accounts_bl;


                if (!accounts_cb.Enabled)
                    accounts_cb.Enabled = true;

                if (current_file != "" && current_file != null && !save_btn.Enabled)
                    save_btn.Enabled = true;

                if (!save_as_btn.Enabled)
                    save_as_btn.Enabled = true;

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Account selected = crsp_manager.Accounts.Single(a => a.id == (int)accounts_cb.SelectedValue);
            AccountForm edit_account = new AccountForm(selected);
            edit_account.Text = "Edit Account";
            
            if (edit_account.ShowDialog() == DialogResult.OK)
            {
                crsp_manager.Update(edit_account.account);
                accounts_bl = new BindingList<Account>(crsp_manager.Accounts);
                accounts_cb.DataSource = accounts_bl;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            int account_id = (int)accounts_cb.SelectedValue;
            string confirmation = "Are you sure you want to delete this account? (This action cannot be undone)";
            if (MessageBox.Show(confirmation, "Delete Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                crsp_manager.Delete(account_id);
                accounts_bl = new BindingList<Account>(crsp_manager.Accounts);
                accounts_cb.DataSource = accounts_bl;
            }
        }

        private void OpenCRSP()
        {
            List<Account> loaded_list = crsp_manager.Load(current_file, this.key);

            if (loaded_list == null)
            {
                MessageBox.Show("Invalid key", "Decryption Failed", MessageBoxButtons.OK);
            }
            else
            {
                crsp_manager.Accounts = loaded_list;
                filename_lbl.Text = "Current File:\n" + current_file;
                save_btn.Enabled = true;
                save_as_btn.Enabled = true;

                accounts_bl = new BindingList<Account>(crsp_manager.Accounts);
                accounts_cb.DataSource = accounts_bl;
                accounts_cb.Enabled = true;

                edit_btn.Enabled = true;
                remove_btn.Enabled = true;
            }
        }
    }

}
