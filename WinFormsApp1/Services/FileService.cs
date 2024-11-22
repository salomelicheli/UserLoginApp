using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    public static class FileService
    {
        private static string currentDirectory = Directory.GetCurrentDirectory();
        private static string usersFilePath = Path.Combine(currentDirectory, "../../../DBFiles/Users.txt");
        //private static string usersFilePath = "Users.txt";
        public static void CreateUser(User user)
        {
            using(var writer = new StreamWriter(usersFilePath, true))
            {
                writer.WriteLine($"{user.Name}|{user.Email}|{user.Password}|{user.Username}|{user.PhoneNumber}|{(int)user.Role.Value}");
            }
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();   
            if(File.Exists(usersFilePath))
            {
                foreach(var line in File.ReadAllLines(usersFilePath))
                {
                    var userItems = line.Split('|');
                    User user = new User(userItems[0], userItems[1], userItems[2], userItems[3], userItems[4], Convert.ToBoolean(int.Parse(userItems[5])));
                    users.Add(user);
                }
            }
            return users;
        }     
    }
}
