using System;

namespace DadJokeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int djIndex;
            string userInput; //yes no input
            bool yesNoInput = false;
            
            //dad joke array. Vertical so it's more human readable
            string[] dadJokes = {
                "It was an emotional wedding. Even the cake was in tiers.",
                "A man was hospitalized with 6 plastic horses inside him. The doctor described his condition as stable!",
                "My friend really changed when she became vegetarian, it's like I've never seen herbivore",
                "Ed has no girlfriend because Sheeran away.",
                "I removed the shell from my racing snail to make it go faster - but it just made it more sluggish.",
                "I bet the butcher he couldn't reach the meat on the top shelf. He said the steaks were too high.",
                "Atheism is a non-prophet organization!",
                "I used to have a fear of hurdles, but then i got over it.",
                "If at first you don't succeed then skydiving is not for you.",
                "What do you call a magic dog? A Labracadabrador.",
                "Jokes with punch lines can be painfully funny.",
                "What do you call cheese that isn't yours? Nacho Cheese." };

            //creating an instance of a random class
            Random rnd = new();

            // creating index
            // int djIndex = rnd.Next(dadJokes.Length);


            Console.WriteLine("Wanna hear a joke? How about two?");
            Console.WriteLine();

            //loops twice
            for (int i = 0; i <= 1; i++)
            {
                // creating index. Index in loop to get a new random value each time
                djIndex = rnd.Next(dadJokes.Length);

                Console.WriteLine($"{dadJokes[djIndex]}");
            }
            // do while loop
            do
            {
                Console.WriteLine("Do you want to hear another joke? (y/n)");

                userInput = Console.ReadLine();

                string lowercaseInput = userInput.ToLower();



                if (userInput == "yes" || userInput == "y")
                {
                    Console.WriteLine("Okay heres another joke");

                    djIndex = rnd.Next(dadJokes.Length);
                    Console.WriteLine();
                    Console.WriteLine($"{dadJokes[djIndex]}");
                }
                else if (userInput == "no" || userInput == "n")
                {
                    Console.WriteLine("Alright, see you next time");
                    yesNoInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (!yesNoInput);

        }//main method
    }//class
}//namespace
