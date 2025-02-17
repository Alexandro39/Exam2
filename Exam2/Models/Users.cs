using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exam2.Models
{
    public class Users
    {



        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
        public Users(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
        }

    }
}
