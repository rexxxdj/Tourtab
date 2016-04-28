namespace Tourtab
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
            this.SuspendLayout();
            // 
            // loginInputLabel
            // 
            this.loginInputLabel.AutoSize = true;
            this.loginInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInputLabel.Location = new System.Drawing.Point(12, 9);
            this.loginInputLabel.Name = "loginInputLabel";
            this.loginInputLabel.Size = new System.Drawing.Size(93, 15);
            this.loginInputLabel.TabIndex = 0;
            this.loginInputLabel.Text = "Введите логин";
            // 
            // loginInputBox
            // 
            this.loginInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInputBox.Location = new System.Drawing.Point(15, 26);
            this.loginInputBox.MaxLength = 100;
            this.loginInputBox.Name = "loginInputBox";
            this.loginInputBox.Size = new System.Drawing.Size(207, 23);
            this.loginInputBox.TabIndex = 1;
            // 
            // passwordInputLabel
            // 
            this.passwordInputLabel.AutoSize = true;
            this.passwordInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInputLabel.Location = new System.Drawing.Point(12, 66);
            this.passwordInputLabel.Name = "passwordInputLabel";
            this.passwordInputLabel.Size = new System.Drawing.Size(102, 15);
            this.passwordInputLabel.TabIndex = 2;
            this.passwordInputLabel.Text = "Введите пароль";
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInputBox.Location = new System.Drawing.Point(15, 84);
            this.passwordInputBox.MaxLength = 100;
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.Size = new System.Drawing.Size(207, 23);
            this.passwordInputBox.TabIndex = 3;
            this.passwordInputBox.UseSystemPasswordChar = true;
            // 
            // authFinishBtn
            // 
            this.authFinishBtn.Location = new System.Drawing.Point(80, 160);
            this.authFinishBtn.Name = "authFinishBtn";
            this.authFinishBtn.Size = new System.Drawing.Size(75, 23);
            this.authFinishBtn.TabIndex = 4;
            this.authFinishBtn.Text = "Войти";
            this.authFinishBtn.UseVisualStyleBackColor = true;
            this.authFinishBtn.Click += new System.EventHandler(this.authFinishBtn_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 201);
            this.Controls.Add(this.authFinishBtn);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.passwordInputLabel);
            this.Controls.Add(this.loginInputBox);
            this.Controls.Add(this.loginInputLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginInputLabel;
        private System.Windows.Forms.TextBox loginInputBox;
        private System.Windows.Forms.Label passwordInputLabel;
        private System.Windows.Forms.TextBox passwordInputBox;
        private System.Windows.Forms.Button authFinishBtn;
    }
}

