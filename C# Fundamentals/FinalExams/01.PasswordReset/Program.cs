using System;

namespace _4.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
            string result = "";
            while (command != "Done")
            {
                string[] temp = command.Split();
                string firstCommand = temp[0];
                switch (firstCommand)
                {
                    case "TakeOdd":
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 == 1)
                            {
                                result += password[i];
                            }
                        }
                        password = result;
                        Console.WriteLine(password);
                        result = "";
                        break;
                    case "Cut":
                        int startIndex = int.Parse(temp[1]);
                        int lenght = int.Parse(temp[2]);
                        password = password.Remove(startIndex, lenght);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = temp[1];
                        string strForReplace = temp[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, strForReplace);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
