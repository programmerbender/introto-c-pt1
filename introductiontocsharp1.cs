using System;

class Program
{
    static void CheckLogin()
    {
        int attempts = 3;
        while (attempts > 0)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            if (username == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect credentials. Please try again.");
                attempts--;
            }
        }
        if (attempts == 0)
        {
            Console.WriteLine("Maximum login attempts reached. Please try again later.");
        }
    }

    static void Main(string[] args)
    {
        CheckLogin();
    }
}
