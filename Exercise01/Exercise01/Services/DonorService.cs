using Exercise01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class DonorService
    {
        public Donor SaveDonorDetails()
        {
            var donor = new Donor();
            Console.WriteLine("Enter Name:");
            donor.Name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            donor.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            donor.PhoneNumber = Console.ReadLine();
            return donor;
        }

        public void LogDonorToFile(string fileName, Donor donor)
        {
            using (StreamWriter writer = new StreamWriter("important.txt"))
            {
                writer.WriteLine("Donor Name: " + donor.Name);
                writer.WriteLine("Donor Email: " + donor.Email);
                writer.WriteLine("Donor PhoneNumber: " + donor.PhoneNumber);
            }
        }
    }
}
