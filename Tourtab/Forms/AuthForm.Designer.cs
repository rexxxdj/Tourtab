﻿namespace Tourtab
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginInputLabel = new System.Windows.Forms.Label();
            this.loginInputBox = new System.Windows.Forms.TextBox();
            this.passwordInputLabel = new System.Windows.Forms.Label();
            this.passwordInputBox = new System.Windows.Forms.TextBox();
            this.authFinishBtn = new System.Windows.Forms.Button();
            this.iamAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginInputLabel
            // 
            this.loginInputLabel.AutoSize = true;
            this.loginInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInputLabel.Location = new System.Drawing.Point(14, 10);
            this.loginInputLabel.Name = "loginInputLabel";
            this.loginInputLabel.Size = new System.Drawing.Size(93, 15);
            this.loginInputLabel.TabIndex = 0;
            this.loginInputLabel.Text = "Введите логин";
            // 
            // loginInputBox
            // 
            this.loginInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInputBox.Location = new System.Drawing.Point(14, 31);
            this.loginInputBox.MaxLength = 100;
            this.loginInputBox.Name = "loginInputBox";
            this.loginInputBox.Size = new System.Drawing.Size(178, 23);
            this.loginInputBox.TabIndex = 1;
            // 
            // passwordInputLabel
            // 
            this.passwordInputLabel.AutoSize = true;
            this.passwordInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInputLabel.Location = new System.Drawing.Point(14, 73);
            this.passwordInputLabel.Name = "passwordInputLabel";
            this.passwordInputLabel.Size = new System.Drawing.Size(102, 15);
            this.passwordInputLabel.TabIndex = 2;
            this.passwordInputLabel.Text = "Введите пароль";
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInputBox.Location = new System.Drawing.Point(14, 93);
            this.passwordInputBox.MaxLength = 100;
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.Size = new System.Drawing.Size(178, 23);
            this.passwordInputBox.TabIndex = 3;
            this.passwordInputBox.UseSystemPasswordChar = true;
            // 
            // authFinishBtn
            // 
            this.authFinishBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authFinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authFinishBtn.Location = new System.Drawing.Point(57, 162);
            this.authFinishBtn.Name = "authFinishBtn";
            this.authFinishBtn.Size = new System.Drawing.Size(83, 27);
            this.authFinishBtn.TabIndex = 4;
            this.authFinishBtn.Text = "Войти";
            this.authFinishBtn.UseVisualStyleBackColor = true;
            this.authFinishBtn.Click += new System.EventHandler(this.authFinishBtn_Click);
            // 
            // iamAdmin
            // 
            this.iamAdmin.AutoSize = true;
            this.iamAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iamAdmin.Location = new System.Drawing.Point(12, 134);
            this.iamAdmin.Name = "iamAdmin";
            this.iamAdmin.Size = new System.Drawing.Size(130, 19);
            this.iamAdmin.TabIndex = 5;
            this.iamAdmin.Text = "Я администратор";
            this.iamAdmin.UseVisualStyleBackColor = true;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(204, 201);
            this.Controls.Add(this.iamAdmin);
            this.Controls.Add(this.authFinishBtn);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.passwordInputLabel);
            this.Controls.Add(this.loginInputBox);
            this.Controls.Add(this.loginInputLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 240);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginInputLabel;
        private System.Windows.Forms.TextBox loginInputBox;
        private System.Windows.Forms.Label passwordInputLabel;
        private System.Windows.Forms.TextBox passwordInputBox;
        private System.Windows.Forms.Button authFinishBtn;
        private System.Windows.Forms.CheckBox iamAdmin;
    }
}

