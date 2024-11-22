using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsApp1.Models;
namespace WinFormsApp1.Services
{
    public static class UserService
    {
        public static List<User> getUsers()
        {
            var users = FileService.GetAllUsers();
            return users;
        }

        public static bool RegisterUser(string name, string email, string password, string username, string phoneNumber, bool isManagerChecked)
        {          
            User newUser = new User(name, email, password, username, phoneNumber, isManagerChecked);  
            FileService.CreateUser(newUser);
            return true;
        }

        private static bool isUsernameValid(string username)
        {
            var users = FileService.GetAllUsers();
            foreach (User existingUser in users)
            {
                if (existingUser.Username == username)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool isEmailValid(string email)
        {
            bool isValid = false;

            foreach(var item in email)
            {
                if(item == '@')
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        public static User AuthenticateUser(string username, string password)
        {
            var users = FileService.GetAllUsers();
            foreach(User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;    
                }
            }
            return null;
        }
    }
}
