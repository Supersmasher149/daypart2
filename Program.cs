using System;
namespace day2part2
{
    class Program
    {
        static void Main()
        {
            int truePasswords = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day2\TextFile1.txt");
            //Console.WriteLine(lines[0]);
            
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
                
                char[] chararry = stringCharacter.ToCharArray();
                
                
                //converts password to char array
                char[] charArrayPassword = password.ToCharArray();
                //converts char array into car
                //char charMinPassword = charArrayPassword[intMin - 1];
                //TODO sometimes the password is not as long as the maximum so it goes out of bounds of the array
                //char charMaxPassword = charArrayPassword[intMax - 1];

                //Console.WriteLine($"{}");

                if (charArrayPassword[intMin - 1] == charCharacter && charArrayPassword[intMax - 1] == charCharacter & ! charArrayPassword[intMin - 1] == charCharacter & charArrayPassword[intMax - 1] == charCharacter)
                {
                truePasswords++;
                //Console.WriteLine("true");
            }
                else
            {
                //Console.WriteLine("false");
            }

        }
            Console.WriteLine(truePasswords);
        }
    }
}
