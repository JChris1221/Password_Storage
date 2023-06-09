﻿
namespace Password_Storage
{
    partial class AccountForm
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
            save_btn = new System.Windows.Forms.Button();
            username_tb = new System.Windows.Forms.TextBox();
            password_tb = new System.Windows.Forms.TextBox();
            acc_name_tb = new System.Windows.Forms.TextBox();
            cancel_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.Location = new System.Drawing.Point(12, 99);
            save_btn.Name = "save_btn";
            save_btn.Size = new System.Drawing.Size(112, 23);
            save_btn.TabIndex = 3;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_account_btn_Click;
            // 
            // username_tb
            // 
            username_tb.Location = new System.Drawing.Point(12, 41);
            username_tb.Name = "username_tb";
            username_tb.PlaceholderText = "Username";
            username_tb.Size = new System.Drawing.Size(240, 23);
            username_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            password_tb.Location = new System.Drawing.Point(12, 70);
            password_tb.Name = "password_tb";
            password_tb.PlaceholderText = "Password";
            password_tb.Size = new System.Drawing.Size(240, 23);
            password_tb.TabIndex = 2;
            // 
            // acc_name_tb
            // 
            acc_name_tb.Location = new System.Drawing.Point(12, 12);
            acc_name_tb.Name = "acc_name_tb";
            acc_name_tb.PlaceholderText = "Account Name";
            acc_name_tb.Size = new System.Drawing.Size(240, 23);
            acc_name_tb.TabIndex = 0;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new System.Drawing.Point(130, 99);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new System.Drawing.Size(122, 23);
            cancel_btn.TabIndex = 4;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(264, 134);
            Controls.Add(cancel_btn);
            Controls.Add(acc_name_tb);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(save_btn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AccountForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.TextBox username_tb;
        public System.Windows.Forms.TextBox password_tb;
        public System.Windows.Forms.TextBox acc_name_tb;
    }
}