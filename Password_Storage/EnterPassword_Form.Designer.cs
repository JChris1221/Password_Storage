﻿
namespace Password_Storage
{
    partial class EnterPassword_Form
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
            password_tb = new System.Windows.Forms.TextBox();
            ok_btn = new System.Windows.Forms.Button();
            cancel_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // password_tb
            // 
            password_tb.Location = new System.Drawing.Point(12, 13);
            password_tb.Name = "password_tb";
            password_tb.PlaceholderText = "Enter Key";
            password_tb.Size = new System.Drawing.Size(316, 23);
            password_tb.TabIndex = 0;
            // 
            // ok_btn
            // 
            ok_btn.Location = new System.Drawing.Point(85, 43);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new System.Drawing.Size(75, 23);
            ok_btn.TabIndex = 1;
            ok_btn.Text = "Enter";
            ok_btn.UseVisualStyleBackColor = true;
            ok_btn.Click += ok_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new System.Drawing.Point(166, 43);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new System.Drawing.Size(75, 23);
            cancel_btn.TabIndex = 2;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // EnterPassword_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 78);
            Controls.Add(cancel_btn);
            Controls.Add(ok_btn);
            Controls.Add(password_tb);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "EnterPassword_Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Enter Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}