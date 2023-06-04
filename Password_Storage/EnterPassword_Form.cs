using System;
using System.Windows.Forms;

namespace Password_Storage
{
    public partial class EnterPassword_Form : Form
    {
        public byte[] key;
        public CrispyEncrypt crispy_encrypt;
        public EnterPassword_Form()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {

            //string check_message = crispy_encrypt.CheckKey(password_tb.Text);
            this.key = crispy_encrypt.HashString(password_tb.Text);
            string check_message = crispy_encrypt.CheckKey(key);

            if (check_message == null)
                this.DialogResult = DialogResult.OK;
            else
                throw new Exception(check_message);

            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
