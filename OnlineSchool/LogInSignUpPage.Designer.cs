namespace OnlineSchool
{
    partial class LogInSignUpPage
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
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelLogInPassword = new System.Windows.Forms.Label();
            this.textBoxLogInPassword = new System.Windows.Forms.TextBox();
            this.labelLogInEmail = new System.Windows.Forms.Label();
            this.textBoxLogInEmail = new System.Windows.Forms.TextBox();
            this.groupBoxSignUp = new System.Windows.Forms.GroupBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxSchool = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelSchool = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxLogInShowPassword = new System.Windows.Forms.CheckBox();
            this.groupBoxLogIn.SuspendLayout();
            this.groupBoxSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.Controls.Add(this.checkBoxLogInShowPassword);
            this.groupBoxLogIn.Controls.Add(this.buttonLogIn);
            this.groupBoxLogIn.Controls.Add(this.labelLogInPassword);
            this.groupBoxLogIn.Controls.Add(this.textBoxLogInPassword);
            this.groupBoxLogIn.Controls.Add(this.labelLogInEmail);
            this.groupBoxLogIn.Controls.Add(this.textBoxLogInEmail);
            this.groupBoxLogIn.Location = new System.Drawing.Point(31, 31);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(239, 211);
            this.groupBoxLogIn.TabIndex = 0;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Text = "LogIn";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(12, 153);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(206, 43);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelLogInPassword
            // 
            this.labelLogInPassword.AutoSize = true;
            this.labelLogInPassword.Location = new System.Drawing.Point(8, 80);
            this.labelLogInPassword.Name = "labelLogInPassword";
            this.labelLogInPassword.Size = new System.Drawing.Size(82, 20);
            this.labelLogInPassword.TabIndex = 3;
            this.labelLogInPassword.Text = "Password:";
            // 
            // textBoxLogInPassword
            // 
            this.textBoxLogInPassword.Location = new System.Drawing.Point(96, 77);
            this.textBoxLogInPassword.Name = "textBoxLogInPassword";
            this.textBoxLogInPassword.Size = new System.Drawing.Size(122, 26);
            this.textBoxLogInPassword.TabIndex = 2;
            // 
            // labelLogInEmail
            // 
            this.labelLogInEmail.AutoSize = true;
            this.labelLogInEmail.Location = new System.Drawing.Point(38, 38);
            this.labelLogInEmail.Name = "labelLogInEmail";
            this.labelLogInEmail.Size = new System.Drawing.Size(52, 20);
            this.labelLogInEmail.TabIndex = 1;
            this.labelLogInEmail.Text = "Email:";
            // 
            // textBoxLogInEmail
            // 
            this.textBoxLogInEmail.Location = new System.Drawing.Point(96, 35);
            this.textBoxLogInEmail.Name = "textBoxLogInEmail";
            this.textBoxLogInEmail.Size = new System.Drawing.Size(122, 26);
            this.textBoxLogInEmail.TabIndex = 0;
            // 
            // groupBoxSignUp
            // 
            this.groupBoxSignUp.Controls.Add(this.checkBoxShowPassword);
            this.groupBoxSignUp.Controls.Add(this.comboBoxGender);
            this.groupBoxSignUp.Controls.Add(this.textBoxSchool);
            this.groupBoxSignUp.Controls.Add(this.textBoxGrade);
            this.groupBoxSignUp.Controls.Add(this.textBoxMobileNumber);
            this.groupBoxSignUp.Controls.Add(this.textBoxPassword);
            this.groupBoxSignUp.Controls.Add(this.textBoxEmail);
            this.groupBoxSignUp.Controls.Add(this.textBoxSurname);
            this.groupBoxSignUp.Controls.Add(this.textBoxName);
            this.groupBoxSignUp.Controls.Add(this.buttonSignUp);
            this.groupBoxSignUp.Controls.Add(this.labelSchool);
            this.groupBoxSignUp.Controls.Add(this.labelGender);
            this.groupBoxSignUp.Controls.Add(this.labelGrade);
            this.groupBoxSignUp.Controls.Add(this.labelMobileNumber);
            this.groupBoxSignUp.Controls.Add(this.labelPassword);
            this.groupBoxSignUp.Controls.Add(this.labelEmail);
            this.groupBoxSignUp.Controls.Add(this.labelSurname);
            this.groupBoxSignUp.Controls.Add(this.labelName);
            this.groupBoxSignUp.Location = new System.Drawing.Point(291, 31);
            this.groupBoxSignUp.Name = "groupBoxSignUp";
            this.groupBoxSignUp.Size = new System.Drawing.Size(512, 424);
            this.groupBoxSignUp.TabIndex = 1;
            this.groupBoxSignUp.TabStop = false;
            this.groupBoxSignUp.Text = "SignUp";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(141, 286);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(348, 28);
            this.comboBoxGender.TabIndex = 16;
            // 
            // textBoxSchool
            // 
            this.textBoxSchool.Location = new System.Drawing.Point(141, 326);
            this.textBoxSchool.Name = "textBoxSchool";
            this.textBoxSchool.Size = new System.Drawing.Size(348, 26);
            this.textBoxSchool.TabIndex = 15;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(141, 245);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(348, 26);
            this.textBoxGrade.TabIndex = 13;
            // 
            // textBoxMobileNumber
            // 
            this.textBoxMobileNumber.Location = new System.Drawing.Point(141, 202);
            this.textBoxMobileNumber.Name = "textBoxMobileNumber";
            this.textBoxMobileNumber.Size = new System.Drawing.Size(348, 26);
            this.textBoxMobileNumber.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(141, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(199, 26);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(141, 116);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(348, 26);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(141, 75);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(348, 26);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 26);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(25, 365);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(465, 43);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Location = new System.Drawing.Point(21, 329);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(62, 20);
            this.labelSchool.TabIndex = 7;
            this.labelSchool.Text = "School:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(21, 287);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 20);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender:";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(21, 245);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(58, 20);
            this.labelGrade.TabIndex = 5;
            this.labelGrade.Text = "Grade:";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Location = new System.Drawing.Point(21, 203);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(115, 20);
            this.labelMobileNumber.TabIndex = 4;
            this.labelMobileNumber.Text = "MobileNumber:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(21, 161);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(21, 77);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(78, 20);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(346, 163);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(144, 24);
            this.checkBoxShowPassword.TabIndex = 17;
            this.checkBoxShowPassword.Text = "ShowPassword";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // checkBoxLogInShowPassword
            // 
            this.checkBoxLogInShowPassword.AutoSize = true;
            this.checkBoxLogInShowPassword.Location = new System.Drawing.Point(74, 115);
            this.checkBoxLogInShowPassword.Name = "checkBoxLogInShowPassword";
            this.checkBoxLogInShowPassword.Size = new System.Drawing.Size(144, 24);
            this.checkBoxLogInShowPassword.TabIndex = 18;
            this.checkBoxLogInShowPassword.Text = "ShowPassword";
            this.checkBoxLogInShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxLogInShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxLogInShowPassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 467);
            this.Controls.Add(this.groupBoxSignUp);
            this.Controls.Add(this.groupBoxLogIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.groupBoxSignUp.ResumeLayout(false);
            this.groupBoxSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogIn;
        private System.Windows.Forms.GroupBox groupBoxSignUp;
        private System.Windows.Forms.Label labelLogInEmail;
        private System.Windows.Forms.TextBox textBoxLogInEmail;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelLogInPassword;
        private System.Windows.Forms.TextBox textBoxLogInPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.TextBox textBoxSchool;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxMobileNumber;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.CheckBox checkBoxLogInShowPassword;
    }
}

