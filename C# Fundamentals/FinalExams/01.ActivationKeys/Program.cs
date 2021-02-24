using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string instruction = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;
            string result = "";
            string curr = "";
            while (instruction != "Generate")
            {
                string[] temp = instruction.Split(">>>");
                string command = temp[0];
                switch (command)
                {
                    case "Slice":
                        startIndex = int.Parse(temp[1]);
                        endIndex = int.Parse(temp[2]);
                        key = key.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(key);
                        break;
                    case "Flip":
                        string condition = temp[1];
                        if (condition == "Lower")
                        {
                            startIndex = int.Parse(temp[2]);
                            endIndex = int.Parse(temp[3]);
                            for (int i = 0; i < key.Length; i++)
                            {
                                if (i >= startIndex && i < endIndex)
                                {
                                    char word = key[i];
                                    result += word;
                                    curr += word;
                                }
                                if (i == endIndex)
                                {
                                    break;
                                }
                            }
                            key = key.Replace(curr, result.ToLower());
                            Console.WriteLine(key);
                            result = "";
                            curr = "";
                        }
                        else if (condition == "Upper")
                        {
                            startIndex = int.Parse(temp[2]);
                            endIndex = int.Parse(temp[3]);
                            for (int i = 0; i < key.Length; i++)
                            {
                                if (i >= startIndex && i < endIndex)
                                {
                                    char word = key[i];
                                    result += word;
                                    curr += word;
                                }
                                if (i == endIndex)
                                {
                                    break;
                                }
                            }
                            key = key.Replace(curr, result.ToUpper());
                            Console.WriteLine(key);
                            result = "";
                            curr = "";
                        }
                        break;
                    case "Contains":
                        string substring = temp[1];
                        if (key.Contains(substring))
                        {
                            Console.WriteLine($"{key} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                }
                instruction = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
