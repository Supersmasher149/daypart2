using System;
namespace day2part2
{
    class Program
    {
        static void Main()
        {
            int truePasswords = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day2\TextFile1.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                //splits the min string
                string[] min = lines[i].Split("-");
                //splits the max string
                string[] max = min[1].Split(" ");
                //splits the character
                string[] character = max[1].Split(":");
                //splits the password
                string password = max[2];

                //convertes max string[] into int
                int intMax = Int32.Parse(max[0]);
                //converts min string[] into int
                int intMin = Int32.Parse(min[0]);
                //converts character into a string
                string stringCharacter = character[0];
                
                //converts string character into a char
                char charCharacter = char.Parse(stringCharacter);
                
                //converts password to char array
                char[] charArrayPassword = password.ToCharArray();

                bool test = charArrayPassword[intMin - 1] == charCharacter | charArrayPassword[intMax - 1] == charCharacter;
                bool test1 = charArrayPassword[intMin - 1] == charCharacter && charArrayPassword[intMax - 1] == charCharacter;

                if (test == true & ! test1)
                {
                truePasswords++;
            }
        }
            Console.WriteLine(truePasswords);
        }
    }
}
