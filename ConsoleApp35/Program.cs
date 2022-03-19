using System;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            do
            {
                Console.WriteLine("daxil edin:");
                username = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(username) || username.Length < 6 || username.Length > 25);


            string password;
            do
            {
                Console.WriteLine("Passwd daxil edin:");
                password = Console.ReadLine();

            } while (!CheckPassword(password));

            User usr = new User(username, password);

            Console.WriteLine($"UseName: {usr.UserName} Password: {usr.Password}");
        }

        static bool CheckPassword(string password)
        {
            bool hDigit = false;
            bool hLower = false;
            bool hUpper = false;

            if (!string.IsNullOrWhiteSpace(password) && password.Length > 7 && password.Length < 26)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                        hDigit = true;
                    else if (char.IsUpper(password[i]))
                        hUpper = true;
                    else if (char.IsLower(password[i]))
                        hLower = true;
                   

                    if (hUpper && hLower && hDigit)
                        return true;
                }
            }

            return false;
        }
    }
}