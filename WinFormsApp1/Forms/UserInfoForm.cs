using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
namespace WinFormsApp1.Forms
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm(User user)
        {
            InitializeComponent();
            SetUserInfo(user);
        }

        private void SetUserInfo(User user)
        {
            NameLabel.Text += user.Name;
            EmailLabel.Text += user.Email;
            PhoneNumberLabel.Text += user.PhoneNumber;
            UserNameLabel.Text += user.Username;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
       
    }
}
