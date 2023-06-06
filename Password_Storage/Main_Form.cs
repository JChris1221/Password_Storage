﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Text;
using System.Drawing.Design;

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
        private void open_btn_Click(object sender, EventArgs e)
        {
            enter_password_form enter_password = new enter_password_form();
            enter_password.crispy_encrypt = this.crispy_encrypt;

            if (open_crsp_dialog.ShowDialog() == DialogResult.OK)
            {
                if (enter_password.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_password.key;
                    Debug.Write(Encoding.ASCII.GetString(this.key));
                    current_file = open_crsp_dialog.FileName;
                    OpenCRSP();
                }
            }
        }

        private void save_btn_Click(Object sender, EventArgs e)
        {
            CRSPManager.SaveCRSP(current_file, accounts, this.key);
            OpenCRSP();
        }

        private void save_as_btn_Click(Object sender, EventArgs e)
        {


            if (save_crsp_dialog.ShowDialog() == DialogResult.OK)
            {
                enter_password_form enter_pass = new enter_password_form();
                enter_pass.crispy_encrypt = this.crispy_encrypt;
                if (enter_pass.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_pass.key;
                    this.current_file = save_crsp_dialog.FileName;
                    CRSPManager.SaveCRSP(current_file, accounts, this.key);
                }

            }
            OpenCRSP();

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

                if (current_file != "" && current_file != null && !save_btn.Enabled)
                    save_btn.Enabled = true;

                if (!save_as_btn.Enabled)
                    save_as_btn.Enabled = true;

            }
        }

        private void OpenCRSP()
        {
            accounts = CRSPManager.LoadCRSP(current_file, this.key);

            if (accounts == null)
            {
                MessageBox.Show("Invalid key", "Decryption Failed", MessageBoxButtons.OK);
                current_file = null;
            }
            else
            {
                filename_lbl.Text = "Current File:\n" + current_file;
                save_btn.Enabled = true;
                save_as_btn.Enabled = true;

                accounts_bl = new BindingList<Account>(accounts);
                accounts_cb.DataSource = accounts_bl;
                accounts_cb.Enabled = true;
            }
        }
    }

}
