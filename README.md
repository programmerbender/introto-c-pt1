using System;

class Program
{
    static void Main()
    {
        string username = "Admin";
        string password = "Admin1234!";
        string enteredUsername, enteredPassword;

        for (int attempt = 0; attempt < 3; attempt++)
        {
            Console.Write("Enter username: ");
            enteredUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            enteredPassword = Console.ReadLine();

            if (enteredUsername == username && enteredPassword == password)
            {
                Console.WriteLine("Login successful!");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect password. Please try again.");
            }
        }

        Console.WriteLine(" You have reached maximum attempts. Access denied. :(");
    }
}
