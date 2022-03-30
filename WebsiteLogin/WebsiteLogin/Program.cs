using System;
using WebsiteLogin.Models;
namespace WebsiteLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Aaaaaaa";
            string password ="Aaaaaa23";
            bool isSuperAdmin = false;
            string section = "asdasd";
            Admin admin = new Admin(username, password, isSuperAdmin, section);
            Console.WriteLine(admin.Username);
            Console.WriteLine("Username daxil edin :");
            username = Console.ReadLine();
            while ( !admin.CheckUsername(username))
            {
                Console.WriteLine("Yeniden daxil edin ");
                username = Console.ReadLine();

            }

            Console.WriteLine("Password daxil edin :");
            password = Console.ReadLine();
            while (!admin.CheckPassword(password))
            {
                Console.WriteLine("Yeniden daxil edin ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Super adminsinizmi? (he/yox)");
            string isSuperAdminStr = Console.ReadLine();

            if(isSuperAdminStr == "he")
            {
                admin.IsSuperAdmin = true;
                Console.WriteLine("Section daxil edin:");
                admin.Section = Console.ReadLine();
                admin.GetInfo(admin);
            }
            else if(isSuperAdminStr == "yox")
            {
                Console.WriteLine("Section daxil edin:");
                admin.Section = Console.ReadLine();
                admin.GetInfo(admin);
            }
            Console.WriteLine("Bizi secdiyiniz ucun teshekkurler!");
            
        }
    }
}
