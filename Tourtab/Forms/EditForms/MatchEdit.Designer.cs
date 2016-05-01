namespace Tourtab.Forms.EditForms
{
    partial class MatchEdit
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
            this.matchRoundLabel = new System.Windows.Forms.Label();
            this.matchRoundBox = new System.Windows.Forms.NumericUpDown();
            this.completeButton = new System.Windows.Forms.Button();
            this.matchSportLabel = new System.Windows.Forms.Label();
            this.matchSportBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.matchDatePickerLabel = new System.Windows.Forms.Label();
            this.matchDatePickerBox = new System.Windows.Forms.DateTimePicker();
            this.matchTimePickerLabel = new System.Windows.Forms.Label();
            this.matchTimePickerBox = new System.Windows.Forms.DateTimePicker();
            this.matchPlaceLabel = new System.Windows.Forms.Label();
            this.matchPlaceBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.matchRoundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // matchRoundLabel
            // 
            this.matchRoundLabel.AutoSize = true;
            this.matchRoundLabel.Location = new System.Drawing.Point(12, 17);
            this.matchRoundLabel.Name = "matchRoundLabel";
            this.matchRoundLabel.Size = new System.Drawing.Size(92, 15);
            this.matchRoundLabel.TabIndex = 0;
            this.matchRoundLabel.Text = "Число раундов";
            // 
            // matchRoundBox
            // 
            this.matchRoundBox.Location = new System.Drawing.Point(110, 15);
            this.matchRoundBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.matchRoundBox.Name = "matchRoundBox";
            this.matchRoundBox.Size = new System.Drawing.Size(162, 21);
            this.matchRoundBox.TabIndex = 1;
            this.matchRoundBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.Location = new System.Drawing.Point(197, 226);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 23);
            this.completeButton.TabIndex = 2;
            this.completeButton.Text = "Готово";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // matchSportLabel
            // 
            this.matchSportLabel.AutoSize = true;
            this.matchSportLabel.Location = new System.Drawing.Point(12, 46);
            this.matchSportLabel.Name = "matchSportLabel";
            this.matchSportLabel.Size = new System.Drawing.Size(73, 15);
            this.matchSportLabel.TabIndex = 3;
            this.matchSportLabel.Text = "Вид спорта";
            // 
            // matchSportBox
            // 
            this.matchSportBox.FormattingEnabled = true;
            this.matchSportBox.Location = new System.Drawing.Point(110, 43);
            this.matchSportBox.Name = "matchSportBox";
            this.matchSportBox.Size = new System.Drawing.Size(162, 23);
            this.matchSportBox.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(15, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // matchDatePickerLabel
            // 
            this.matchDatePickerLabel.AutoSize = true;
            this.matchDatePickerLabel.Location = new System.Drawing.Point(12, 139);
            this.matchDatePickerLabel.Name = "matchDatePickerLabel";
            this.matchDatePickerLabel.Size = new System.Drawing.Size(110, 15);
            this.matchDatePickerLabel.TabIndex = 7;
            this.matchDatePickerLabel.Text = "Дата проведения";
            // 
            // matchDatePickerBox
            // 
            this.matchDatePickerBox.Location = new System.Drawing.Point(15, 157);
            this.matchDatePickerBox.Name = "matchDatePickerBox";
            this.matchDatePickerBox.Size = new System.Drawing.Size(210, 21);
            this.matchDatePickerBox.TabIndex = 8;
            // 
            // matchTimePickerLabel
            // 
            this.matchTimePickerLabel.AutoSize = true;
            this.matchTimePickerLabel.Location = new System.Drawing.Point(12, 199);
            this.matchTimePickerLabel.Name = "matchTimePickerLabel";
            this.matchTimePickerLabel.Size = new System.Drawing.Size(118, 15);
            this.matchTimePickerLabel.TabIndex = 9;
            this.matchTimePickerLabel.Text = "Время проведения";
            // 
            // matchTimePickerBox
            // 
            this.matchTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.matchTimePickerBox.Location = new System.Drawing.Point(136, 194);
            this.matchTimePickerBox.Name = "matchTimePickerBox";
            this.matchTimePickerBox.ShowUpDown = true;
            this.matchTimePickerBox.Size = new System.Drawing.Size(89, 21);
            this.matchTimePickerBox.TabIndex = 10;
            // 
            // matchPlaceLabel
            // 
            this.matchPlaceLabel.AutoSize = true;
            this.matchPlaceLabel.Location = new System.Drawing.Point(12, 75);
            this.matchPlaceLabel.Name = "matchPlaceLabel";
            this.matchPlaceLabel.Size = new System.Drawing.Size(118, 15);
            this.matchPlaceLabel.TabIndex = 11;
            this.matchPlaceLabel.Text = "Место проведения";
            // 
            // matchPlaceBox
            // 
            this.matchPlaceBox.Location = new System.Drawing.Point(15, 94);
            this.matchPlaceBox.Multiline = true;
            this.matchPlaceBox.Name = "matchPlaceBox";
            this.matchPlaceBox.Size = new System.Drawing.Size(257, 42);
            this.matchPlaceBox.TabIndex = 12;
            // 
            // MatchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.matchPlaceBox);
            this.Controls.Add(this.matchPlaceLabel);
            this.Controls.Add(this.matchTimePickerBox);
            this.Controls.Add(this.matchTimePickerLabel);
            this.Controls.Add(this.matchDatePickerBox);
            this.Controls.Add(this.matchDatePickerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.matchSportBox);
            this.Controls.Add(this.matchSportLabel);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.matchRoundBox);
            this.Controls.Add(this.matchRoundLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MatchEdit";
            this.Text = "Редактирование матча";
            ((System.ComponentModel.ISupportInitialize)(this.matchRoundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchRoundLabel;
        private System.Windows.Forms.NumericUpDown matchRoundBox;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Label matchSportLabel;
        private System.Windows.Forms.ComboBox matchSportBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label matchDatePickerLabel;
        private System.Windows.Forms.DateTimePicker matchDatePickerBox;
        private System.Windows.Forms.Label matchTimePickerLabel;
        private System.Windows.Forms.DateTimePicker matchTimePickerBox;
        private System.Windows.Forms.Label matchPlaceLabel;
        private System.Windows.Forms.TextBox matchPlaceBox;
    }
}