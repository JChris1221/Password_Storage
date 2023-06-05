
namespace Password_Storage
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            load_btn = new System.Windows.Forms.Button();
            account_lbl = new System.Windows.Forms.Label();
            filename_lbl = new System.Windows.Forms.Label();
            username_lbl = new System.Windows.Forms.Label();
            password_lbl = new System.Windows.Forms.Label();
            accounts_cb = new System.Windows.Forms.ComboBox();
            add_account_btn = new System.Windows.Forms.Button();
            date_saved_tb = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // load_btn
            // 
            load_btn.Location = new System.Drawing.Point(12, 12);
            load_btn.Name = "load_btn";
            load_btn.Size = new System.Drawing.Size(328, 23);
            load_btn.TabIndex = 2;
            load_btn.Text = "Load CRSP";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // account_lbl
            // 
            account_lbl.AutoSize = true;
            account_lbl.Location = new System.Drawing.Point(12, 89);
            account_lbl.Name = "account_lbl";
            account_lbl.Size = new System.Drawing.Size(90, 15);
            account_lbl.TabIndex = 3;
            account_lbl.Text = "Account Name:";
            // 
            // filename_lbl
            // 
            filename_lbl.AutoSize = true;
            filename_lbl.Location = new System.Drawing.Point(12, 39);
            filename_lbl.Name = "filename_lbl";
            filename_lbl.Size = new System.Drawing.Size(81, 15);
            filename_lbl.TabIndex = 5;
            filename_lbl.Text = "No file loaded";
            // 
            // username_lbl
            // 
            username_lbl.BackColor = System.Drawing.SystemColors.Control;
            username_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            username_lbl.Location = new System.Drawing.Point(12, 112);
            username_lbl.Name = "username_lbl";
            username_lbl.Padding = new System.Windows.Forms.Padding(1);
            username_lbl.Size = new System.Drawing.Size(328, 21);
            username_lbl.TabIndex = 6;
            username_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            password_lbl.BackColor = System.Drawing.SystemColors.Control;
            password_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            password_lbl.Location = new System.Drawing.Point(12, 138);
            password_lbl.Name = "password_lbl";
            password_lbl.Padding = new System.Windows.Forms.Padding(1);
            password_lbl.Size = new System.Drawing.Size(328, 21);
            password_lbl.TabIndex = 7;
            password_lbl.Text = "Password";
            // 
            // accounts_cb
            // 
            accounts_cb.Enabled = false;
            accounts_cb.FormattingEnabled = true;
            accounts_cb.Location = new System.Drawing.Point(108, 86);
            accounts_cb.Name = "accounts_cb";
            accounts_cb.Size = new System.Drawing.Size(232, 23);
            accounts_cb.TabIndex = 8;
            accounts_cb.SelectedIndexChanged += accounts_cb_SelectedIndexChanged;
            // 
            // add_account_btn
            // 
            add_account_btn.Location = new System.Drawing.Point(12, 218);
            add_account_btn.Name = "add_account_btn";
            add_account_btn.Size = new System.Drawing.Size(328, 23);
            add_account_btn.TabIndex = 9;
            add_account_btn.Text = "Add Account";
            add_account_btn.UseVisualStyleBackColor = true;
            add_account_btn.Click += add_account_btn_Click;
            // 
            // date_saved_tb
            // 
            date_saved_tb.BackColor = System.Drawing.SystemColors.Control;
            date_saved_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            date_saved_tb.Location = new System.Drawing.Point(12, 166);
            date_saved_tb.Name = "date_saved_tb";
            date_saved_tb.Padding = new System.Windows.Forms.Padding(1);
            date_saved_tb.Size = new System.Drawing.Size(328, 21);
            date_saved_tb.TabIndex = 11;
            date_saved_tb.Text = "Date Saved";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 247);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(328, 23);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(358, 280);
            Controls.Add(button1);
            Controls.Add(date_saved_tb);
            Controls.Add(add_account_btn);
            Controls.Add(accounts_cb);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(filename_lbl);
            Controls.Add(account_lbl);
            Controls.Add(load_btn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main_Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Password Storage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label account_lbl;
        private System.Windows.Forms.Label filename_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.ComboBox accounts_cb;
        private System.Windows.Forms.Button add_account_btn;
        private System.Windows.Forms.Label date_saved_tb;
        private System.Windows.Forms.Button button1;
    }
}

