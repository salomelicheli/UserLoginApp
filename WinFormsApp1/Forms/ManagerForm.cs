using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Services;

namespace WinFormsApp1.Forms
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            SetManagerFormInfo();
        }

        private void SetManagerFormInfo()
        {
            ListBox listBox1 = new ListBox() 
            { Location = new System.Drawing.Point(20, 20), Width = 300, Height = 150 };
            this.Controls.Add(listBox1);

         
            var users = UserService.getUsers();
            List<string> list = new List<string>();

            foreach( var user in users )
            {
                list.Add($"{user.Name}|{user.Email}|{user.Password}|{user.Username}|{user.PhoneNumber}|{user.Role}");
                
            }
            listBox1.DataSource = list;
        }
    }
}
