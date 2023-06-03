using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace Password_Storage
{
    public partial class Main_Form : Form
    {
        private List<Account> accounts;
        private string key;
        private string current_file;
        public Main_Form()
        {
            InitializeComponent();
        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_json = new OpenFileDialog();
            EnterPassword_Form enter_password = new EnterPassword_Form();

            if (load_json.ShowDialog() == DialogResult.OK)
            {
                if (enter_password.ShowDialog() == DialogResult.OK)
                {
                    this.key = enter_password.key;
                    current_file = load_json.FileName;
                    filename_lbl.Text = "Current File: " + current_file;
                    LoadJson(current_file);
                }
            }
        }

        private void accounts_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selected = accounts.Single(a => a.id == (int)accounts_cb.SelectedValue);
            try
            {
                username_lbl.Text = CrispyEncrypt.Decrypt(selected.username, key);
                password_lbl.Text = CrispyEncrypt.Decrypt(selected.password, key);
                date_saved_tb.Text = selected.date_saved.ToString("dddd, dd MMMM yyyy");
            }
            catch (CryptographicException ce)
            {
                MessageBox.Show(ce.Message, "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                current_file = "";
                filename_lbl.Text = "No File Selected";
                accounts_cb.Enabled = false;
                accounts_cb.DataSource = null;
                accounts_cb.Text = "";
            }
        }

        private void add_account_btn_Click(object sender, EventArgs e)
        {
            AddAccount_Form add_form = new AddAccount_Form();
            add_form.current_id = accounts.Last().id + 1;
            if (add_form.ShowDialog() == DialogResult.OK)
            {
                Account account = add_form.account;
                account.username = CrispyEncrypt.Encrpyt(account.username, key);
                account.password = CrispyEncrypt.Encrpyt(account.password, key);
                accounts.Add(account);

                //Save JSON
                SaveToFile(current_file);

                //Reload JSON_File
                LoadJson(current_file);
                MessageBox.Show("Account Added");
            }
        }

        private string SerializeAccounts(List<Account> accounts)
        {
            return null;
        }


        private void LoadJson(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            accounts_cb.Enabled = true;
            accounts_cb.DisplayMember = "account_name";
            accounts_cb.ValueMember = "id";
            accounts_cb.DataSource = accounts;
        }

        private void SaveToFile(string filename)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "yyyy-MM-dd";
            settings.Formatting = Formatting.Indented;
            File.WriteAllText(filename, JsonConvert.SerializeObject(this.accounts, settings));
        }

        private void CreateFile(List<Account> accounts, string filename)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "yyyy-MM-dd";
            settings.Formatting = Formatting.Indented;
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, accounts);
            }
        }
    }

}
