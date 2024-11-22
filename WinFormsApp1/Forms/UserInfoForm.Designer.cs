namespace WinFormsApp1.Forms
{
    partial class UserInfoForm
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
            UserInfoLabel = new Label();
            LogoutButton = new Button();
            NameLabel = new Label();
            EmailLabel = new Label();
            PhoneNumberLabel = new Label();
            UserNameLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // UserInfoLabel
            // 
            UserInfoLabel.AutoSize = true;
            UserInfoLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            UserInfoLabel.ForeColor = SystemColors.ActiveCaptionText;
            UserInfoLabel.Location = new Point(37, 66);
            UserInfoLabel.Name = "UserInfoLabel";
            UserInfoLabel.Size = new Size(292, 81);
            UserInfoLabel.TabIndex = 1;
            UserInfoLabel.Text = "User Info";
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = SystemColors.ActiveCaption;
            LogoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(338, 590);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(255, 49);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Log out";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(68, 242);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(65, 25);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLabel.Location = new Point(68, 304);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(60, 25);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Email:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(68, 360);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(141, 25);
            PhoneNumberLabel.TabIndex = 8;
            PhoneNumberLabel.Text = "Phone number:";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(68, 412);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(100, 25);
            UserNameLabel.TabIndex = 9;
            UserNameLabel.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 242);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 713);
            Controls.Add(label1);
            Controls.Add(UserNameLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(LogoutButton);
            Controls.Add(UserInfoLabel);
            Name = "UserInfoForm";
            Text = "UserInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserInfoLabel;
        private Button LogoutButton;
        private Label NameLabel;
        private Label EmailLabel;
        private Label PhoneNumberLabel;
        private Label UserNameLabel;
        private Label label1;
    }
}