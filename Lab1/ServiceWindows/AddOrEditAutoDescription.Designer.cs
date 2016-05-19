namespace Lab1.ServiceWindows {
    partial class AddOrEditAutoDescription {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOwners = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxIsSetDate = new System.Windows.Forms.CheckBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.groupBoxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(98, 23);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(98, 49);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия владельца";
            // 
            // comboBoxOwners
            // 
            this.comboBoxOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwners.FormattingEnabled = true;
            this.comboBoxOwners.Location = new System.Drawing.Point(28, 102);
            this.comboBoxOwners.Name = "comboBoxOwners";
            this.comboBoxOwners.Size = new System.Drawing.Size(174, 21);
            this.comboBoxOwners.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCreate.Location = new System.Drawing.Point(6, 27);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(98, 20);
            this.dateTimeCreate.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(98, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxIsSetDate
            // 
            this.checkBoxIsSetDate.AutoSize = true;
            this.checkBoxIsSetDate.Checked = true;
            this.checkBoxIsSetDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsSetDate.Location = new System.Drawing.Point(28, 131);
            this.checkBoxIsSetDate.Name = "checkBoxIsSetDate";
            this.checkBoxIsSetDate.Size = new System.Drawing.Size(105, 17);
            this.checkBoxIsSetDate.TabIndex = 10;
            this.checkBoxIsSetDate.Text = "Заводить дату?";
            this.checkBoxIsSetDate.UseVisualStyleBackColor = true;
            this.checkBoxIsSetDate.CheckedChanged += new System.EventHandler(this.checkBoxIsSetDate_CheckedChanged);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.label4);
            this.groupBoxDate.Controls.Add(this.dateTimeCreate);
            this.groupBoxDate.Location = new System.Drawing.Point(28, 149);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(200, 71);
            this.groupBoxDate.TabIndex = 11;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Дата прохождения тех. Осмотра";
            // 
            // AddOrEditAutoDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.checkBoxIsSetDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxOwners);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AddOrEditAutoDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOwners;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxIsSetDate;
        private System.Windows.Forms.GroupBox groupBoxDate;
    }
}