using Exercise01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class UserService
    {
        public void CreateUser()
        {
            var user = new User();
            Console.WriteLine("Enter Name:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            user.PhoneNumber = Console.ReadLine();

            this.LogDonorToFile("user created", user);
        }

        public void LogDonorToFile(string fileName, User user)
        {
            using (StreamWriter writer = new StreamWriter(fileName + ".txt"))
            {
                writer.WriteLine("Donor Name: " + user.Name);
                writer.WriteLine("Donor Email: " + user.Email);
                writer.WriteLine("Donor PhoneNumber: " + user.PhoneNumber);
            }
        }
    }
}
