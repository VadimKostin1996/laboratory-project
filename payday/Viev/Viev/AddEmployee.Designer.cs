namespace View
{
    partial class AddEmployeeForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.casingRadioButton = new System.Windows.Forms.RadioButton();
            this.hourlyPayRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(53, 133);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(53, 158);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(49, 13);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Surname";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Location = new System.Drawing.Point(53, 181);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(59, 13);
            this.Patronymic.TabIndex = 2;
            this.Patronymic.Text = "Patronymic";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(134, 154);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 4;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(134, 178);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicTextBox.TabIndex = 5;
            this.patronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymicTextBox_KeyPress);
            // 
            // casingRadioButton
            // 
            this.casingRadioButton.AutoSize = true;
            this.casingRadioButton.Location = new System.Drawing.Point(36, 19);
            this.casingRadioButton.Name = "casingRadioButton";
            this.casingRadioButton.Size = new System.Drawing.Size(57, 17);
            this.casingRadioButton.TabIndex = 6;
            this.casingRadioButton.TabStop = true;
            this.casingRadioButton.Text = "Casing";
            this.casingRadioButton.UseVisualStyleBackColor = true;
            this.casingRadioButton.CheckedChanged += new System.EventHandler(this.casingRadioButton_CheckedChanged);
            // 
            // hourlyPayRadioButton
            // 
            this.hourlyPayRadioButton.AutoSize = true;
            this.hourlyPayRadioButton.Location = new System.Drawing.Point(36, 44);
            this.hourlyPayRadioButton.Name = "hourlyPayRadioButton";
            this.hourlyPayRadioButton.Size = new System.Drawing.Size(75, 17);
            this.hourlyPayRadioButton.TabIndex = 7;
            this.hourlyPayRadioButton.TabStop = true;
            this.hourlyPayRadioButton.Text = "Hourly pay";
            this.hourlyPayRadioButton.UseVisualStyleBackColor = true;
            this.hourlyPayRadioButton.CheckedChanged += new System.EventHandler(this.hourlyPayRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hourlyPayRadioButton);
            this.groupBox1.Controls.Add(this.casingRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View salary";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(88, 332);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addOrModifyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(262, 332);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(53, 211);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 15;
            this.salaryLabel.Text = "Salary";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(53, 237);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(30, 13);
            this.rateLabel.TabIndex = 16;
            this.rateLabel.Text = "Rate";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(53, 259);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(30, 13);
            this.hourLabel.TabIndex = 17;
            this.hourLabel.Text = "Hour";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(53, 289);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(48, 13);
            this.paymentLabel.TabIndex = 18;
            this.paymentLabel.Text = "Payment";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(134, 204);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 11;
            this.salaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTextBox_KeyPress);
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(134, 230);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 12;
            this.rateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateTextBox_KeyPress);
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(134, 256);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourTextBox.TabIndex = 13;
            this.hourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourTextBox_KeyPress);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(134, 282);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTextBox.TabIndex = 14;
            this.paymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentTextBox_KeyPress);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 384);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddEmployeeForm";
            this.Text = "Add employee";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.RadioButton casingRadioButton;
        private System.Windows.Forms.RadioButton hourlyPayRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
    }
}