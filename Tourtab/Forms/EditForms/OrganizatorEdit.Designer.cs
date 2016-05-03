namespace Tourtab.Forms.EditForms
{
    partial class OrganizatorEdit
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
            this.completeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.surnameInputBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageInputBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addressInputBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.loginInputBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInputBox = new System.Windows.Forms.TextBox();
            this.isAdminBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.Location = new System.Drawing.Point(183, 372);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(87, 27);
            this.completeButton.TabIndex = 0;
            this.completeButton.Text = "Готово";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(12, 372);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(9, 67);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(62, 15);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameInputBox
            // 
            this.nameInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameInputBox.Location = new System.Drawing.Point(90, 22);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(180, 21);
            this.nameInputBox.TabIndex = 4;
            // 
            // surnameInputBox
            // 
            this.surnameInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameInputBox.Location = new System.Drawing.Point(90, 64);
            this.surnameInputBox.Name = "surnameInputBox";
            this.surnameInputBox.Size = new System.Drawing.Size(180, 21);
            this.surnameInputBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(9, 108);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(55, 15);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Возраст";
            // 
            // ageInputBox
            // 
            this.ageInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageInputBox.Location = new System.Drawing.Point(90, 106);
            this.ageInputBox.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageInputBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ageInputBox.Name = "ageInputBox";
            this.ageInputBox.Size = new System.Drawing.Size(180, 21);
            this.ageInputBox.TabIndex = 7;
            this.ageInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ageInputBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Адрес";
            // 
            // addressInputBox
            // 
            this.addressInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressInputBox.Location = new System.Drawing.Point(90, 152);
            this.addressInputBox.Multiline = true;
            this.addressInputBox.Name = "addressInputBox";
            this.addressInputBox.Size = new System.Drawing.Size(180, 45);
            this.addressInputBox.TabIndex = 9;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(9, 264);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 15);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Логин";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(34, 215);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(213, 23);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Сгененрировать логин и пароль";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // loginInputBox
            // 
            this.loginInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInputBox.Location = new System.Drawing.Point(90, 261);
            this.loginInputBox.Name = "loginInputBox";
            this.loginInputBox.Size = new System.Drawing.Size(180, 21);
            this.loginInputBox.TabIndex = 12;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 301);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(51, 15);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Пароль";
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInputBox.Location = new System.Drawing.Point(90, 298);
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.Size = new System.Drawing.Size(180, 21);
            this.passwordInputBox.TabIndex = 14;
            // 
            // isAdminBox
            // 
            this.isAdminBox.AutoSize = true;
            this.isAdminBox.Location = new System.Drawing.Point(12, 335);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(165, 19);
            this.isAdminBox.TabIndex = 15;
            this.isAdminBox.Text = "Права администратора";
            this.isAdminBox.UseVisualStyleBackColor = true;
            // 
            // OrganizatorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.isAdminBox);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginInputBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.addressInputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageInputBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.surnameInputBox);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.completeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "OrganizatorEdit";
            this.Text = "Редактирование организатора";
            this.Load += new System.EventHandler(this.OrganizatorEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.TextBox surnameInputBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressInputBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox loginInputBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInputBox;
        private System.Windows.Forms.CheckBox isAdminBox;
    }
}