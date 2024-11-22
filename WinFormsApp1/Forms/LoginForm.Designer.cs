namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginLabel = new Label();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            LoginButton = new Button();
            NotAMemberLabel = new Label();
            SwitchToRegistrationButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = SystemColors.ControlLight;
            LoginLabel.Font = new Font("SPFebos", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = SystemColors.ActiveCaptionText;
            LoginLabel.Location = new Point(260, 161);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(118, 49);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Login";
            // 
            // UsernameField
            // 
            UsernameField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameField.Location = new Point(127, 259);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(384, 47);
            UsernameField.TabIndex = 2;
            // 
            // PasswordField
            // 
            PasswordField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordField.Location = new Point(127, 334);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(384, 47);
            PasswordField.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(184, 408);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(255, 49);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // NotAMemberLabel
            // 
            NotAMemberLabel.AutoSize = true;
            NotAMemberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NotAMemberLabel.ForeColor = SystemColors.HotTrack;
            NotAMemberLabel.Location = new Point(106, 481);
            NotAMemberLabel.Name = "NotAMemberLabel";
            NotAMemberLabel.Size = new Size(178, 31);
            NotAMemberLabel.TabIndex = 5;
            NotAMemberLabel.Text = "Not a member?";
            // 
            // SwitchToRegistrationButton
            // 
            SwitchToRegistrationButton.BackColor = SystemColors.Highlight;
            SwitchToRegistrationButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SwitchToRegistrationButton.Location = new Point(316, 474);
            SwitchToRegistrationButton.Name = "SwitchToRegistrationButton";
            SwitchToRegistrationButton.Size = new Size(218, 49);
            SwitchToRegistrationButton.TabIndex = 6;
            SwitchToRegistrationButton.Text = "Register Now";
            SwitchToRegistrationButton.UseVisualStyleBackColor = false;
            SwitchToRegistrationButton.Click += SwitchToRegistrationButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(647, 713);
            Controls.Add(SwitchToRegistrationButton);
            Controls.Add(NotAMemberLabel);
            Controls.Add(LoginButton);
            Controls.Add(PasswordField);
            Controls.Add(UsernameField);
            Controls.Add(LoginLabel);
            Name = "LoginForm";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private Button LoginButton;
        private Label NotAMemberLabel;
        private Button SwitchToRegistrationButton;
    }
}
