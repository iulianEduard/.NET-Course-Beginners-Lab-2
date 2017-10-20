using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ConsoleApp.Iterations
{
    public class WorkingWithIterations
    {
        public void ForLoopExample()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i > 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
                if(i % 2== 0)
                    continue;

                Console.WriteLine("12354");
            }

            int index = 0;
            for(index = 1; index < 5; index++)
            {
                
            }

            // "i" is not visible here.

        }

        public void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string ceVreiTu in carTypes)
            {
                Console.WriteLine(ceVreiTu);
            }

            for(int i = 0; i < carTypes.Length -1; i++)
            {
                Console.WriteLine(carTypes[i]);
            }
            
            int[] myInts = { 10, 20, 30, 40 };

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        public void WhileLoopExample()
        {
            string userIsDone = "yes";
            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        public void DoWhileLoopExample()
        {
            string userIsDone = "yes";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }

        public void IfElseExample()
        {
            // This is illegal, given that Length returns an int, not a bool.
            string stringData = "My textual data";
            if (stringData.Length <= 99 || stringData.Length > 10)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            else if(stringData.Length < 10)
            {
                Console.WriteLine("not that long");
            }
            else
            {
                Console.WriteLine("5697");
            }

            Console.WriteLine("1234");
        }

        public void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    Console.WriteLine("123");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }
    }
}
