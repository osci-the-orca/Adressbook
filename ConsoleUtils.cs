using System;

namespace Adressbook
{
    static class ConsoleUtils
    {
        public static string ReadString(string prompt = "")
        {
            if (!string.IsNullOrWhiteSpace(prompt))
            {
                Console.Write(prompt);
            }
            string output = Console.ReadLine();
            return output;
        }

        public static void WriteString(string value = "")
        {
            Console.Write(value);
        }
    }
}
