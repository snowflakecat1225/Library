namespace Library
{
    partial class UserAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAuth));
            this.UserAuthButton = new System.Windows.Forms.Button();
            this.AdminAuthButton = new System.Windows.Forms.Button();
            this.LoginTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordMtb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // UserAuthButton
            // 
            this.UserAuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.UserAuthButton.FlatAppearance.BorderSize = 0;
            this.UserAuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAuthButton.Location = new System.Drawing.Point(38, 156);
            this.UserAuthButton.Name = "UserAuthButton";
            this.UserAuthButton.Size = new System.Drawing.Size(132, 28);
            this.UserAuthButton.TabIndex = 4;
            this.UserAuthButton.Text = "Вход";
            this.UserAuthButton.UseVisualStyleBackColor = false;
            this.UserAuthButton.Click += new System.EventHandler(this.UserAuthButton_Click);
            // 
            // AdminAuthButton
            // 
            this.AdminAuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.AdminAuthButton.FlatAppearance.BorderSize = 0;
            this.AdminAuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminAuthButton.Location = new System.Drawing.Point(12, 207);
            this.AdminAuthButton.Name = "AdminAuthButton";
            this.AdminAuthButton.Size = new System.Drawing.Size(100, 24);
            this.AdminAuthButton.TabIndex = 5;
            this.AdminAuthButton.Text = "Библиотекарь";
            this.AdminAuthButton.UseVisualStyleBackColor = false;
            this.AdminAuthButton.Click += new System.EventHandler(this.AdminAuthButton_Click);
            // 
            // LoginTb
            // 
            this.LoginTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTb.Location = new System.Drawing.Point(12, 55);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.Size = new System.Drawing.Size(185, 26);
            this.LoginTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // PasswordMtb
            // 
            this.PasswordMtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordMtb.Location = new System.Drawing.Point(12, 107);
            this.PasswordMtb.Name = "PasswordMtb";
            this.PasswordMtb.Size = new System.Drawing.Size(185, 26);
            this.PasswordMtb.TabIndex = 2;
            this.PasswordMtb.UseSystemPasswordChar = true;
            // 
            // UserAuth
            // 
            this.AcceptButton = this.UserAuthButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(209, 243);
            this.Controls.Add(this.PasswordMtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTb);
            this.Controls.Add(this.AdminAuthButton);
            this.Controls.Add(this.UserAuthButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserAuthButton;
        private System.Windows.Forms.Button AdminAuthButton;
        private System.Windows.Forms.TextBox LoginTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PasswordMtb;
    }
}

