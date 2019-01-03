using Exercise01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Services
{
    public class EmailService
    {
        public Email SaveEmail()
        {
            var email = new Email();
            Console.WriteLine("Enter From Email:");
            email.FromEmail = Console.ReadLine();
            Console.WriteLine("Enter To Email");
            email.ToEmail = Console.ReadLine();
            Console.WriteLine("Enter Subject");
            email.Subject = Console.ReadLine();
            Console.WriteLine("Enter Body");
            email.Body = Console.ReadLine();
            return email;
        }

        public void LogEmailToFile(string fileName, Email email)
        {
            using (StreamWriter writer = new StreamWriter("important.txt"))
            {
                writer.WriteLine("From Email : " + email.FromEmail);
                writer.WriteLine("To Email : " + email.ToEmail);
                writer.WriteLine("Subject : " + email.Subject);
                writer.WriteLine("Body : " + email.Body);
            }
        }
    }
}
