using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voterdetails
{
    class Program
    {
        static void Main(string[] args)
        {
			string name;
			DateTime dob;
			Console.WriteLine("Enter your Name :");
			name = Console.ReadLine();
			Console.WriteLine("Enter your Date of Birth :");
			bool res = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob);
			if (!res)
			{
				Console.WriteLine("Format is else");
			}
			else
			{
				Console.WriteLine(dob.ToString("MM-dd-yyyy"));

			}
			var today = DateTime.Today;
			var age = today.Year - dob.Year;
			Console.WriteLine("your Age is :" + age);
			if (age > 18)
				Console.WriteLine("You are Eligible for Voting !!");
			else
				Console.WriteLine("You are Not Eligible for Voting !!");
			Console.Read();
		}
    }
}
