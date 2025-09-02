using System;
using System.Windows.Forms;
using Password_Storage.Core.Interfaces.Utilities;
using Password_Storage.Core.Utilities;

namespace Password_Storage
{
    public partial class EnterPasswordForm : Form
    {
        public byte[] key;
        public IEncryptor crispy_encrypt;
        public EnterPasswordForm()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {

            if (password_tb.Text == "")
                MessageBox.Show("Enter Password", "Enter Password");

            else
            {
                this.key = crispy_encrypt.HashString(password_tb.Text);
                string check_message = crispy_encrypt.CheckKey(key);

                if (check_message == null)
                    this.DialogResult = DialogResult.OK;
                else
                    throw new Exception(check_message);

                this.Close();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ok_btn.PerformClick();
        }
    }
}
