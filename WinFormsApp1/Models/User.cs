using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public enum UserRole
    {
        USER,
        MANAGER
    }
    public class User
    {
        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username field is required")]
        public string Username { get; set; }    
        public string? PhoneNumber { get; set; }
        public UserRole? Role { get; set; }
        

        public User(string name, string email, string password, string username, string? phoneNumber, bool isManagerChecked)
        {
            Name = name;
            Email = email;
            Password = password;
            Username = username;
            PhoneNumber = phoneNumber;            
            Role = isManagerChecked ? UserRole.MANAGER : UserRole.USER;
        }
    }
}
