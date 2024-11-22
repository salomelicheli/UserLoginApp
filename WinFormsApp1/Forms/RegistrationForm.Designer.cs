namespace WinFormsApp1.Forms
{
    partial class RegistrationForm
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
            SomeRegisterLabel = new Label();
            NameTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            RegistrationButton = new Button();
            AlreadyAMemberField = new Label();
            SwitchToLoginPageButton = new Button();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IsRequiredLabelForName = new Label();
            IsRequiredLabelForUsername = new Label();
            IsRequiredLabelForPassword = new Label();
            IsRequiredLabelForEmail = new Label();
            IsRequiredLabelForPhoneNumber = new Label();
            ManagerCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // SomeRegisterLabel
            // 
            SomeRegisterLabel.AutoSize = true;
            SomeRegisterLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            SomeRegisterLabel.ForeColor = SystemColors.ActiveCaptionText;
            SomeRegisterLabel.Location = new Point(195, 17);
            SomeRegisterLabel.Name = "SomeRegisterLabel";
            SomeRegisterLabel.Size = new Size(256, 81);
            SomeRegisterLabel.TabIndex = 0;
            SomeRegisterLabel.Text = "Sign Up";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(169, 132);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(384, 47);
            NameTextBox.TabIndex = 3;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.Location = new Point(169, 209);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(384, 47);
            UserNameTextBox.TabIndex = 4;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberTextBox.Location = new Point(169, 434);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(384, 47);
            PhoneNumberTextBox.TabIndex = 5;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(169, 359);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(384, 47);
            EmailTextBox.TabIndex = 6;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = SystemColors.ActiveCaption;
            RegistrationButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationButton.Location = new Point(184, 555);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(255, 49);
            RegistrationButton.TabIndex = 7;
            RegistrationButton.Text = "Sign Up";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // AlreadyAMemberField
            // 
            AlreadyAMemberField.AutoSize = true;
            AlreadyAMemberField.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AlreadyAMemberField.ForeColor = SystemColors.HotTrack;
            AlreadyAMemberField.Location = new Point(54, 617);
            AlreadyAMemberField.Name = "AlreadyAMemberField";
            AlreadyAMemberField.Size = new Size(219, 31);
            AlreadyAMemberField.TabIndex = 8;
            AlreadyAMemberField.Text = "Already a member?";
            // 
            // SwitchToLoginPageButton
            // 
            SwitchToLoginPageButton.BackColor = SystemColors.Highlight;
            SwitchToLoginPageButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SwitchToLoginPageButton.Location = new Point(389, 610);
            SwitchToLoginPageButton.Name = "SwitchToLoginPageButton";
            SwitchToLoginPageButton.Size = new Size(218, 49);
            SwitchToLoginPageButton.TabIndex = 9;
            SwitchToLoginPageButton.Text = "Switch to login page";
            SwitchToLoginPageButton.UseVisualStyleBackColor = false;
            SwitchToLoginPageButton.Click += SwitchToLoginPageButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(169, 285);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(384, 47);
            PasswordTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 145);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 298);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 222);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 13;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 378);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 14;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 447);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 15;
            label5.Text = "Phone num:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // IsRequiredLabelForName
            // 
            IsRequiredLabelForName.AutoSize = true;
            IsRequiredLabelForName.BackColor = Color.White;
            IsRequiredLabelForName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsRequiredLabelForName.ForeColor = Color.FromArgb(192, 0, 0);
            IsRequiredLabelForName.Location = new Point(27, 132);
            IsRequiredLabelForName.Name = "IsRequiredLabelForName";
            IsRequiredLabelForName.Size = new Size(20, 28);
            IsRequiredLabelForName.TabIndex = 16;
            IsRequiredLabelForName.Text = "*";
            // 
            // IsRequiredLabelForUsername
            // 
            IsRequiredLabelForUsername.AutoSize = true;
            IsRequiredLabelForUsername.BackColor = Color.White;
            IsRequiredLabelForUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsRequiredLabelForUsername.ForeColor = Color.FromArgb(192, 0, 0);
            IsRequiredLabelForUsername.Location = new Point(27, 209);
            IsRequiredLabelForUsername.Name = "IsRequiredLabelForUsername";
            IsRequiredLabelForUsername.Size = new Size(20, 28);
            IsRequiredLabelForUsername.TabIndex = 17;
            IsRequiredLabelForUsername.Text = "*";
            // 
            // IsRequiredLabelForPassword
            // 
            IsRequiredLabelForPassword.AutoSize = true;
            IsRequiredLabelForPassword.BackColor = Color.White;
            IsRequiredLabelForPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsRequiredLabelForPassword.ForeColor = Color.FromArgb(192, 0, 0);
            IsRequiredLabelForPassword.Location = new Point(27, 285);
            IsRequiredLabelForPassword.Name = "IsRequiredLabelForPassword";
            IsRequiredLabelForPassword.Size = new Size(20, 28);
            IsRequiredLabelForPassword.TabIndex = 18;
            IsRequiredLabelForPassword.Text = "*";
            // 
            // IsRequiredLabelForEmail
            // 
            IsRequiredLabelForEmail.AutoSize = true;
            IsRequiredLabelForEmail.BackColor = Color.White;
            IsRequiredLabelForEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsRequiredLabelForEmail.ForeColor = Color.FromArgb(192, 0, 0);
            IsRequiredLabelForEmail.Location = new Point(27, 359);
            IsRequiredLabelForEmail.Name = "IsRequiredLabelForEmail";
            IsRequiredLabelForEmail.Size = new Size(20, 28);
            IsRequiredLabelForEmail.TabIndex = 19;
            IsRequiredLabelForEmail.Text = "*";
            // 
            // IsRequiredLabelForPhoneNumber
            // 
            IsRequiredLabelForPhoneNumber.AutoSize = true;
            IsRequiredLabelForPhoneNumber.BackColor = Color.White;
            IsRequiredLabelForPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsRequiredLabelForPhoneNumber.ForeColor = Color.FromArgb(192, 0, 0);
            IsRequiredLabelForPhoneNumber.Location = new Point(27, 434);
            IsRequiredLabelForPhoneNumber.Name = "IsRequiredLabelForPhoneNumber";
            IsRequiredLabelForPhoneNumber.Size = new Size(20, 28);
            IsRequiredLabelForPhoneNumber.TabIndex = 20;
            IsRequiredLabelForPhoneNumber.Text = "*";
            // 
            // ManagerCheckbox
            // 
            ManagerCheckbox.AutoSize = true;
            ManagerCheckbox.Location = new Point(452, 506);
            ManagerCheckbox.Name = "ManagerCheckbox";
            ManagerCheckbox.Size = new Size(162, 24);
            ManagerCheckbox.TabIndex = 21;
            ManagerCheckbox.Text = "Sign up as Manager";
            ManagerCheckbox.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 713);
            Controls.Add(ManagerCheckbox);
            Controls.Add(IsRequiredLabelForPhoneNumber);
            Controls.Add(IsRequiredLabelForEmail);
            Controls.Add(IsRequiredLabelForPassword);
            Controls.Add(IsRequiredLabelForUsername);
            Controls.Add(IsRequiredLabelForName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(SwitchToLoginPageButton);
            Controls.Add(AlreadyAMemberField);
            Controls.Add(RegistrationButton);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(SomeRegisterLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SomeRegisterLabel;
        private TextBox NameTextBox;
        private TextBox UserNameTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
        private Button RegistrationButton;
        private Label AlreadyAMemberField;
        private Button SwitchToLoginPageButton;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label IsRequiredLabelForName;
        private Label IsRequiredLabelForUsername;
        private Label IsRequiredLabelForPassword;
        private Label IsRequiredLabelForEmail;
        private Label IsRequiredLabelForPhoneNumber;
        private CheckBox ManagerCheckbox;
    }
}