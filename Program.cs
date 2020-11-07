using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs
{
    class Program
    {
        #pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
        #pragma warning restore IDE0060 // Remove unused parameter
        {
            /*
            Author: ...
            Objective ...
            Directions ...
            Continue...
            */
            string author = "Author: Alexander Rock";
            string objective = "Objective: This program is meant to demonstrate a small sample of C#.";
            string directions = "Directions: Choose a word for each part of speech specified. Once you're done, read your short story out loud!";

            Console.WriteLine(author + "\n \n" + objective + "\n \n" + directions + "\n \n \n");
            Console.Write("\nPress Enter to continue...");
            Console.ReadLine();

            //Clear Text
            Console.Clear();

            // Let the user know that the program is starting:
            string start = "The Mad Libz program is about to start...";

            Console.WriteLine(start);
            Console.Write("\n \n \nPress Enter to continue...");
            Console.ReadLine();

            //Clear Text
            Console.Clear();

            // Mad Libz Title
            string title = "Mad Libz";

            Console.WriteLine(title + ("\n \n \n"));

            // Define user input and variables:
            Console.Write("Enter an adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string plurNoun1 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter the second adjective: ");
            string adj2 = Console.ReadLine();

            Console.Write("Enter a name of a human body part: ");
            string bodyPart1 = Console.ReadLine();

            Console.Write("Enter the third adjective: ");
            string adj3 = Console.ReadLine();

            Console.Write("Enter the second plural noun: ");
            string plurNoun2 = Console.ReadLine();

            Console.Write("Enter the name of a second human body part: ");
            string bodyPart2 = Console.ReadLine();
            Console.Write("Enter the fourth adjective: ");
            string adj4 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string adverb1 = Console.ReadLine();

            Console.Write("Finally, enter the second noun: ");
            string noun2 = Console.ReadLine();

            Console.Clear();

            // The template for the story:

            string story = $"The force is a mystical, {adj1} power. As Jedi Master Obi-Wan Kenobi once said, \"The Force is an energy field, created by all living {plurNoun1}, that surrounds us, penetrates us, and binds the {noun1} together.\" Using the power of the force, a Jedi can do many {adj2} things, like using the Force to exercise {bodyPart1} control over {adj3}-minded {plurNoun2}. A Jedi can also use the Force to move objects with his or her {bodyPart2}. It doesn't matter how {adj4} these objects are; it only matters how {adverb1} the Jedi believes in the Force. Most importantly, the Force teaches a Jedi to rely on his or her feelings. As Obi-Wan Kenobi told his student, Luke {noun2}.";


            // Print the story:
            Console.WriteLine("Creating story...");
            Console.Write("\n \n \n Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine(story);
            Console.Write("\n \n \n Thank you for your time! \n \n \n Press Enter to exit.");
            Console.ReadLine();
            Console.Clear();
      
        }
    }
}
