using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1.Services
{
    public static class UserValidation
    {
        public static bool IsPasswordValid(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(password); 
        }

        public static bool isEmailValid(string email)
        {
            bool isValid = false;

            foreach (var item in email)
            {
                if (item == '@')
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
