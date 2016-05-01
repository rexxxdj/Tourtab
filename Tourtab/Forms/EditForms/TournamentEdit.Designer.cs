namespace Tourtab.Forms.EditForms
{
    partial class TournamentEdit
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
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameInputBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.placeLabel = new System.Windows.Forms.Label();
            this.tournamentMatchesLabel = new System.Windows.Forms.Label();
            this.tournamentMatchesTable = new System.Windows.Forms.DataGridView();
            this.tournamentMatchesAddButton = new System.Windows.Forms.Button();
            this.tournamentMatchesDeleteButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tournamentPlaceInputBox = new System.Windows.Forms.TextBox();
            this.tournamentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.tournamentTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentMatchesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.Location = new System.Drawing.Point(462, 406);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 23);
            this.completeButton.TabIndex = 0;
            this.completeButton.Text = "Готово";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 9);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(145, 15);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "Наименование турнира";
            // 
            // tournamentNameInputBox
            // 
            this.tournamentNameInputBox.Location = new System.Drawing.Point(15, 27);
            this.tournamentNameInputBox.MaxLength = 80;
            this.tournamentNameInputBox.Name = "tournamentNameInputBox";
            this.tournamentNameInputBox.Size = new System.Drawing.Size(522, 21);
            this.tournamentNameInputBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(15, 406);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(12, 61);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(118, 15);
            this.placeLabel.TabIndex = 4;
            this.placeLabel.Text = "Место проведения";
            // 
            // tournamentMatchesLabel
            // 
            this.tournamentMatchesLabel.AutoSize = true;
            this.tournamentMatchesLabel.Location = new System.Drawing.Point(12, 181);
            this.tournamentMatchesLabel.Name = "tournamentMatchesLabel";
            this.tournamentMatchesLabel.Size = new System.Drawing.Size(94, 15);
            this.tournamentMatchesLabel.TabIndex = 8;
            this.tournamentMatchesLabel.Text = "Список матчей";
            // 
            // tournamentMatchesTable
            // 
            this.tournamentMatchesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentMatchesTable.Location = new System.Drawing.Point(15, 199);
            this.tournamentMatchesTable.Name = "tournamentMatchesTable";
            this.tournamentMatchesTable.Size = new System.Drawing.Size(420, 150);
            this.tournamentMatchesTable.TabIndex = 9;
            // 
            // tournamentMatchesAddButton
            // 
            this.tournamentMatchesAddButton.Location = new System.Drawing.Point(441, 243);
            this.tournamentMatchesAddButton.Name = "tournamentMatchesAddButton";
            this.tournamentMatchesAddButton.Size = new System.Drawing.Size(96, 23);
            this.tournamentMatchesAddButton.TabIndex = 10;
            this.tournamentMatchesAddButton.Text = "Добавить";
            this.tournamentMatchesAddButton.UseVisualStyleBackColor = true;
            this.tournamentMatchesAddButton.Click += new System.EventHandler(this.tournamentMatchesAddButton_Click);
            // 
            // tournamentMatchesDeleteButton
            // 
            this.tournamentMatchesDeleteButton.Location = new System.Drawing.Point(441, 281);
            this.tournamentMatchesDeleteButton.Name = "tournamentMatchesDeleteButton";
            this.tournamentMatchesDeleteButton.Size = new System.Drawing.Size(96, 23);
            this.tournamentMatchesDeleteButton.TabIndex = 11;
            this.tournamentMatchesDeleteButton.Text = "Исключить";
            this.tournamentMatchesDeleteButton.UseVisualStyleBackColor = true;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(15, 380);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 15);
            this.errorMessage.TabIndex = 12;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 117);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(110, 15);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Дата проведения";
            // 
            // tournamentPlaceInputBox
            // 
            this.tournamentPlaceInputBox.Location = new System.Drawing.Point(15, 80);
            this.tournamentPlaceInputBox.Name = "tournamentPlaceInputBox";
            this.tournamentPlaceInputBox.Size = new System.Drawing.Size(522, 21);
            this.tournamentPlaceInputBox.TabIndex = 14;
            // 
            // tournamentDatePicker
            // 
            this.tournamentDatePicker.Location = new System.Drawing.Point(15, 135);
            this.tournamentDatePicker.Name = "tournamentDatePicker";
            this.tournamentDatePicker.Size = new System.Drawing.Size(242, 21);
            this.tournamentDatePicker.TabIndex = 15;
            this.tournamentDatePicker.Value = new System.DateTime(2016, 5, 1, 17, 32, 23, 0);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(280, 117);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(118, 15);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Время проведения";
            // 
            // tournamentTimePicker
            // 
            this.tournamentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tournamentTimePicker.Location = new System.Drawing.Point(283, 135);
            this.tournamentTimePicker.Name = "tournamentTimePicker";
            this.tournamentTimePicker.ShowUpDown = true;
            this.tournamentTimePicker.Size = new System.Drawing.Size(80, 21);
            this.tournamentTimePicker.TabIndex = 17;
            // 
            // TournamentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 441);
            this.Controls.Add(this.tournamentTimePicker);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.tournamentDatePicker);
            this.Controls.Add(this.tournamentPlaceInputBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.tournamentMatchesDeleteButton);
            this.Controls.Add(this.tournamentMatchesAddButton);
            this.Controls.Add(this.tournamentMatchesTable);
            this.Controls.Add(this.tournamentMatchesLabel);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tournamentNameInputBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.completeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(565, 480);
            this.MinimumSize = new System.Drawing.Size(565, 480);
            this.Name = "TournamentEdit";
            this.Text = "Редактирование турнира";
            this.Load += new System.EventHandler(this.TournamentEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tournamentMatchesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameInputBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label tournamentMatchesLabel;
        private System.Windows.Forms.DataGridView tournamentMatchesTable;
        private System.Windows.Forms.Button tournamentMatchesAddButton;
        private System.Windows.Forms.Button tournamentMatchesDeleteButton;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox tournamentPlaceInputBox;
        private System.Windows.Forms.DateTimePicker tournamentDatePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker tournamentTimePicker;
    }
}