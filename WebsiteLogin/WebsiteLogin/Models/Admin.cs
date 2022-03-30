using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteLogin.Models
{
    class Admin:User
    {
        public Admin(string username, string password, bool isSuperAdmin, string section):base(username, password)
        {
            this.IsSuperAdmin = isSuperAdmin;
            this.Section = section;
        }
        public bool IsSuperAdmin;
        public string Section;

        public void GetInfo(Admin admin)
        {
            Console.WriteLine($"Username: {Username}, Password: {Password}, Is super admin?: {IsSuperAdmin}, Section: {Section}");
        }
    }
}
