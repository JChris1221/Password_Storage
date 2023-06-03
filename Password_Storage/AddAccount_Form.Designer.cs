
namespace Password_Storage
{
    partial class AddAccount_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_btn = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.acc_name_tb = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 99);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(112, 23);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_account_btn_Click);
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(12, 41);
            this.username_tb.Name = "username_tb";
            this.username_tb.PlaceholderText = "Username";
            this.username_tb.Size = new System.Drawing.Size(240, 23);
            this.username_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(12, 70);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.PlaceholderText = "Password";
            this.password_tb.Size = new System.Drawing.Size(240, 23);
            this.password_tb.TabIndex = 2;
            // 
            // acc_name_tb
            // 
            this.acc_name_tb.Location = new System.Drawing.Point(12, 12);
            this.acc_name_tb.Name = "acc_name_tb";
            this.acc_name_tb.PlaceholderText = "Account Name";
            this.acc_name_tb.Size = new System.Drawing.Size(240, 23);
            this.acc_name_tb.TabIndex = 3;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(130, 99);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(122, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // AddAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 134);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.acc_name_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.add_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddAccount_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox acc_name_tb;
        private System.Windows.Forms.Button cancel_btn;
    }
}