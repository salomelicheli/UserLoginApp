using WinFormsApp1.Forms;
using WinFormsApp1.Services;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SwitchToRegistrationButton_Click(object sender, EventArgs e)
        {
            var RegistrationPage = new RegistrationForm();
            RegistrationPage.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = UsernameField.Text;
            var password = PasswordField.Text;  

            var user = UserService.AuthenticateUser(username, password);

            if(user.Role == Models.UserRole.MANAGER)
            {
                ShowManagerForm();
            }
            else
            {
                var userInfoPage = new UserInfoForm(user);
                userInfoPage.Show();
                this.Hide();
            }

          
        }

        private void ShowManagerForm()
        {
            ManagerForm managerForm = new ManagerForm();
            this.Hide();
            managerForm.Show();
        }
    }
}
