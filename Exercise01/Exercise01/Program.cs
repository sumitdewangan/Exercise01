using Exercise01.Models;
using Exercise01.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Program
    {
        public static EmailService emailService = new EmailService();
        public static UserService userService = new UserService();

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Choices:");
            Console.WriteLine("1. Save Donor Details");
            Console.WriteLine("2. Send a mail");

            var optionChoosen = Convert.ToInt32(Console.ReadLine());
            if (optionChoosen == 1)
            {
                userService.CreateUser();
            }
            else if(optionChoosen == 2)
            {
                emailService.SaveEmail();
            }
        }
    }
}
