using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string firstname;
                string surname;
                int age;

                Console.WriteLine("Please enter you first name: ");
                firstname = Console.ReadLine();
                Console.WriteLine("Please enter your surename: ");
                surname = Console.ReadLine();
                Console.WriteLine("Please enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    Console.WriteLine("So your name is {0} {1} and you are {2} years old." +
                    " Sorry but, you're too young to participate. Please try again. " +
                    "", firstname, surname, age);
                }
                else if (age > 100)
                {
                    Console.WriteLine("Sorry but, that is not possible. Please try again...");
                }
                else
                {
                    Console.WriteLine("Congratulations ! You're able to participate");
                }
            }
        }
    }
}
