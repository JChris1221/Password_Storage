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
    public partial class EnterPassword_Form : Form
    {
        public string key;
        public EnterPassword_Form()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string check_message = CrispyEncrypt.CheckKey(password_tb.Text);

            if (check_message == null)
            {
                this.key = password_tb.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(check_message, "Invalid Encryption Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
