using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Services;
using WinFormsApp1.Models;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            SetRequiredFields();
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Name.Contains("TextBox"))
                {
                    textBox.ForeColor = Color.Black;
                }
            }
            var name = NameTextBox.Text;
            var email = EmailTextBox.Text;
            var phoneNumber = PhoneNumberTextBox.Text;
            var username = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;

            var isManagerCheckbox = ManagerCheckbox.Checked;

          

            bool userInfoIsValid = true;
            bool isEmailValid = UserValidation.isEmailValid(email);
            bool isPasswordValid = UserValidation.IsPasswordValid(password);

            if (!isEmailValid || !isPasswordValid)
            {
                userInfoIsValid = false;

                if (!isEmailValid)
                {
                    EmailTextBox.ForeColor = Color.Red;

                }
                if (!isPasswordValid)
                {
                    PasswordTextBox.ForeColor = Color.Red;
                }
                return;
            }

            UserService.RegisterUser(name, email, password, username, phoneNumber, isManagerCheckbox);

            SwitchToLoginPageButton_Click(sender, e);
        }

        private void SwitchToLoginPageButton_Click(object sender, EventArgs e)
        {
            var logingPage = new LoginForm();
            logingPage.Show();
            this.Hide();
        }

        private void SetRequiredFields()
        {
            Type type = typeof(User);
            PropertyInfo[] propertyInfos = type.GetProperties();
            Label[] isRequiredLabels = new Label[propertyInfos.Length];
            int index = 0;
            foreach (var control in this.Controls)
            {
                if (control is Label label && label.Name.Contains("IsRequiredLabel"))
                {
                    isRequiredLabels[index] = label;
                    //Array.Resize(ref isRequiredLabels, index + 2);
                    index++;
                   
                }
            }
         
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                var propertyAttribute = propertyInfo.GetCustomAttribute<RequiredAttribute>();
                if (propertyAttribute == null)
                {
                    var propertyName = propertyInfo.Name;

                    foreach(var label  in isRequiredLabels)
                    {
                        if (label!=null && label.Name.Contains(propertyName))
                        {
                            label.Hide();
                        }
                    }
                                                   

                }

            }
        }

    
    }
}
