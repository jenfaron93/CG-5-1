using System;

namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please enter your first name: ");
			string firstName = Console.ReadLine();

			Console.WriteLine("Please enter your last name: ");
			string lastName = Console.ReadLine();

			string fullName = CombineNames(firstName, lastName); //storing the returned full name from method CombineNames in variable fullName

			Console.WriteLine($"Your full name is {fullName}.");
			Console.ReadLine();
        }

	   private static string CombineNames(string firstName, string lastName){ //passing in two string parameters and returning the combined string

			string fullName = firstName + " " + lastName;
			return fullName;
	   }
    }
}
