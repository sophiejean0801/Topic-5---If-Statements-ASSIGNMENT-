namespace Topic_5___If_Statements_ASSIGNMENT__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            // If Statements
            Console.WriteLine("Please enter your current weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your weight on Earth is " + weight + " pounds.");
            Console.WriteLine("I have information on the following planets: ");
            Console.WriteLine("1. Venus\n2. Mars\n3. Jupiter\n4. Saturn\n5. Uranus\n6. Neptune");
            Console.WriteLine("Please enter the number of the planet you wish to visit: ");
            int planetChoice;
            if (int.TryParse(Console.ReadLine(), out planetChoice))
            {
                if (planetChoice == 1)
                {
                    Console.WriteLine("Your weight on Venus would be " + weight * 0.78);
                }
                else if (planetChoice == 2)
                {
                    Console.WriteLine("Your weight on Mars would be " + weight * 0.39);
                }
                else if (planetChoice == 3)
                {
                    Console.WriteLine("Your weight on Jupiter would be " + weight * 2.65);
                }
                else if (planetChoice == 4)
                {
                    Console.WriteLine("Your weight on Saturn would be " + weight * 1.17);
                }
                else if (planetChoice == 5)
                {

                    Console.WriteLine("Your weight on Uranus would be " + weight * 1.05);
                }
                else if (planetChoice == 6)
                {
                    Console.WriteLine("Your weight on Neptune would be " + weight * 1.23);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                }

                // Part 2 - Stupid Number GUessing Game

                Console.WriteLine("I'm thinking of a number between 1 and 10. Guess what it is? ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 7)
                {
                    Console.WriteLine("You got it!");
                }
                else if (number == 6 || number == 8)
                {
                    Console.WriteLine("So close! The correct number is 7.");
                }
                else
                {
                    Console.WriteLine("You're so far off it isn't even funny. It was 7.");
                }

                // Part 3 - Mini Quiz
                int score = 0;
                Console.WriteLine("Welcome to the random pop quiz that was sprung on you! ");
                Console.WriteLine("What is the capital of France? ");
                string capital = Console.ReadLine();
                if (capital == "Paris" || capital == "PARIS" || capital == "Pris")
                {
                    Console.WriteLine("Correct!");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("The capital of France is Paris.");
                }
                Console.WriteLine("What is " + 5 + " + " + 5 + "? ");
                int sum = Convert.ToInt32(Console.ReadLine());
                if (sum == 10)
                {
                    Console.WriteLine("You're not an idiot!");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("5 + 5 is 10 >:(.");
                }
                Console.WriteLine("What is the largest planet in our solar system? ");
                string planet = Console.ReadLine();
                if (planet == "Jupiter")
                {
                    Console.WriteLine("Correct!");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("You're stupid, Jupiter is the largest planet in our solar system.");

                }
                Console.WriteLine("THis one might be tricky. What is the largest mammal? ");
                string mammal = Console.ReadLine();
                if (mammal == "Blue Whale")
                {
                    Console.WriteLine("Correct!");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("The Blue Whale is the largest mammal.");
                }
                Console.WriteLine("Final Score: " + score + "/4");
                Console.WriteLine("Final Percentage Grade: " + (score / 4.0) * 100 + "%");
                if (score == 1)
                {
                    Console.WriteLine("You got 1 out of 4 correct. You're a failure.");
                }
                else if (score == 2)
                {
                    Console.WriteLine("You got 2 out of 4 correct. You're average.");
                }
                else if (score == 3)
                {
                    Console.WriteLine("You got 3 out of 4 correct. You're smart.");
                }
                else if (score == 4)
                {
                    Console.WriteLine("You got 4 out of 4 correct. You're a genius.");
                }
                else
                {
                    Console.WriteLine("You got 0 out of 4 correct. There is no hope for you.");
                }
    }
}
