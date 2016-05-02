namespace Tourtab.Forms.EditForms
{
    partial class SportEdit
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
            this.sportTypeLabel = new System.Windows.Forms.Label();
            this.sportTypeInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.Location = new System.Drawing.Point(183, 160);
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
            this.cancelButton.Location = new System.Drawing.Point(15, 160);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // sportTypeLabel
            // 
            this.sportTypeLabel.AutoSize = true;
            this.sportTypeLabel.Location = new System.Drawing.Point(15, 15);
            this.sportTypeLabel.Name = "sportTypeLabel";
            this.sportTypeLabel.Size = new System.Drawing.Size(73, 15);
            this.sportTypeLabel.TabIndex = 2;
            this.sportTypeLabel.Text = "Вид спорта";
            // 
            // sportTypeInputBox
            // 
            this.sportTypeInputBox.Location = new System.Drawing.Point(15, 34);
            this.sportTypeInputBox.Multiline = true;
            this.sportTypeInputBox.Name = "sportTypeInputBox";
            this.sportTypeInputBox.Size = new System.Drawing.Size(255, 120);
            this.sportTypeInputBox.TabIndex = 3;
            // 
            // SportEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.sportTypeInputBox);
            this.Controls.Add(this.sportTypeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.completeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SportEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Редактирование вида спорта";
            this.Load += new System.EventHandler(this.SportEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sportTypeLabel;
        private System.Windows.Forms.TextBox sportTypeInputBox;
    }
}