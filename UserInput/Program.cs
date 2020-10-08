using System;
using System.Runtime.InteropServices;

namespace UserInput
{
    public class UserInput
    {
        public static int GetIntFromUser(string prompt)
        {
            int result;
            string userInput;

            // loop until we return an int
            while (true)
            {
                // 1 & 2: Prompt and Read
                Console.Write(prompt);
                userInput = Console.ReadLine();

                // attempt to convert
                if (int.TryParse(userInput, out result))
                {
                    // good input;
                    return result;
                }
                // bad input
                Console.WriteLine("That isd not a valid input.");
            }
        }
    }
}