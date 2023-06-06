﻿
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
            account_lbl = new System.Windows.Forms.Label();
            filename_lbl = new System.Windows.Forms.Label();
            username_lbl = new System.Windows.Forms.Label();
            password_lbl = new System.Windows.Forms.Label();
            accounts_cb = new System.Windows.Forms.ComboBox();
            add_account_btn = new System.Windows.Forms.Button();
            date_saved_tb = new System.Windows.Forms.Label();
            save_crsp_dialog = new System.Windows.Forms.SaveFileDialog();
            open_crsp_dialog = new System.Windows.Forms.OpenFileDialog();
            menu_strip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            open_btn = new System.Windows.Forms.ToolStripMenuItem();
            save_btn = new System.Windows.Forms.ToolStripMenuItem();
            save_as_btn = new System.Windows.Forms.ToolStripMenuItem();
            closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menu_strip.SuspendLayout();
            SuspendLayout();
            // 
            // account_lbl
            // 
            account_lbl.AutoSize = true;
            account_lbl.Location = new System.Drawing.Point(18, 47);
            account_lbl.Name = "account_lbl";
            account_lbl.Size = new System.Drawing.Size(90, 15);
            account_lbl.TabIndex = 3;
            account_lbl.Text = "Account Name:";
            // 
            // filename_lbl
            // 
            filename_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            filename_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            filename_lbl.Location = new System.Drawing.Point(18, 202);
            filename_lbl.Name = "filename_lbl";
            filename_lbl.Size = new System.Drawing.Size(328, 45);
            filename_lbl.TabIndex = 7;
            filename_lbl.Text = "No file...";
            // 
            // username_lbl
            // 
            username_lbl.BackColor = System.Drawing.SystemColors.Control;
            username_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            username_lbl.Location = new System.Drawing.Point(18, 73);
            username_lbl.Name = "username_lbl";
            username_lbl.Padding = new System.Windows.Forms.Padding(1);
            username_lbl.Size = new System.Drawing.Size(328, 21);
            username_lbl.TabIndex = 2;
            username_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            password_lbl.BackColor = System.Drawing.SystemColors.Control;
            password_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            password_lbl.Location = new System.Drawing.Point(18, 103);
            password_lbl.Name = "password_lbl";
            password_lbl.Padding = new System.Windows.Forms.Padding(1);
            password_lbl.Size = new System.Drawing.Size(328, 21);
            password_lbl.TabIndex = 3;
            password_lbl.Text = "Password";
            // 
            // accounts_cb
            // 
            accounts_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            accounts_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            accounts_cb.DisplayMember = "account_name";
            accounts_cb.Enabled = false;
            accounts_cb.FormattingEnabled = true;
            accounts_cb.Location = new System.Drawing.Point(114, 44);
            accounts_cb.Name = "accounts_cb";
            accounts_cb.Size = new System.Drawing.Size(232, 23);
            accounts_cb.TabIndex = 1;
            accounts_cb.ValueMember = "id";
            accounts_cb.SelectedIndexChanged += accounts_cb_SelectedIndexChanged;
            // 
            // add_account_btn
            // 
            add_account_btn.Location = new System.Drawing.Point(113, 165);
            add_account_btn.Name = "add_account_btn";
            add_account_btn.Size = new System.Drawing.Size(128, 24);
            add_account_btn.TabIndex = 5;
            add_account_btn.Text = "Add Account";
            add_account_btn.UseVisualStyleBackColor = true;
            add_account_btn.Click += add_account_btn_Click;
            // 
            // date_saved_tb
            // 
            date_saved_tb.BackColor = System.Drawing.SystemColors.Control;
            date_saved_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            date_saved_tb.Location = new System.Drawing.Point(18, 133);
            date_saved_tb.Name = "date_saved_tb";
            date_saved_tb.Padding = new System.Windows.Forms.Padding(1);
            date_saved_tb.Size = new System.Drawing.Size(328, 21);
            date_saved_tb.TabIndex = 4;
            date_saved_tb.Text = "Date Saved";
            // 
            // save_crsp_dialog
            // 
            save_crsp_dialog.DefaultExt = "crsp";
            save_crsp_dialog.Filter = "crispy encrypt files (*.crsp)|*.crsp";
            // 
            // open_crsp_dialog
            // 
            open_crsp_dialog.DefaultExt = "crsp";
            open_crsp_dialog.Filter = "crispy encrypt files (*.crsp)|*.crsp";
            // 
            // menu_strip
            // 
            menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menu_strip.Location = new System.Drawing.Point(0, 0);
            menu_strip.Name = "menu_strip";
            menu_strip.Size = new System.Drawing.Size(358, 24);
            menu_strip.TabIndex = 9;
            menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { open_btn, save_btn, save_as_btn, closeFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // open_btn
            // 
            open_btn.Name = "open_btn";
            open_btn.Size = new System.Drawing.Size(124, 22);
            open_btn.Text = "Open...";
            open_btn.Click += open_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Enabled = false;
            save_btn.Name = "save_btn";
            save_btn.Size = new System.Drawing.Size(124, 22);
            save_btn.Text = "Save";
            save_btn.Click += save_btn_Click;
            // 
            // save_as_btn
            // 
            save_as_btn.Enabled = false;
            save_as_btn.Name = "save_as_btn";
            save_as_btn.Size = new System.Drawing.Size(124, 22);
            save_as_btn.Text = "Save As...";
            save_as_btn.Click += save_as_btn_Click;
            // 
            // closeFileToolStripMenuItem
            // 
            closeFileToolStripMenuItem.Enabled = false;
            closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            closeFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            closeFileToolStripMenuItem.Text = "Close File";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(358, 256);
            Controls.Add(date_saved_tb);
            Controls.Add(add_account_btn);
            Controls.Add(accounts_cb);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(filename_lbl);
            Controls.Add(account_lbl);
            Controls.Add(menu_strip);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menu_strip;
            MaximizeBox = false;
            Name = "Main_Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Password Storage";
            menu_strip.ResumeLayout(false);
            menu_strip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label account_lbl;
        private System.Windows.Forms.Label filename_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.ComboBox accounts_cb;
        private System.Windows.Forms.Button add_account_btn;
        private System.Windows.Forms.Label date_saved_tb;
        private System.Windows.Forms.SaveFileDialog save_crsp_dialog;
        private System.Windows.Forms.OpenFileDialog open_crsp_dialog;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_btn;
        private System.Windows.Forms.ToolStripMenuItem save_btn;
        private System.Windows.Forms.ToolStripMenuItem save_as_btn;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
    }
}

