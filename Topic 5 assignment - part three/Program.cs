namespace Topic_5_assignment___part_three
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int score = 0;
            int answerOne;
            string answerTwo, answerThree, answerFour;

            //Question one
            Console.WriteLine("Quiz time!");
            Console.WriteLine(" ");
            Console.WriteLine("Question one: How many books are in the Wicked series?");
            int.TryParse(Console.ReadLine(), out answerOne);

            if (answerOne == 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Correct! Gregory Maguire wrote four books within the world of Oz");
                score += 1;
            }
            else
            {
                Console.WriteLine(" ");
            }

            //Question two
            Console.WriteLine(" ");
            Console.WriteLine("Question two: What is the title of the second book in the Wicked series?");
            answerTwo = Console.ReadLine();

            if (answerTwo.ToUpper() == "SON OF A WITCH")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Correct! ");
                score += 1;
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. The title of the second book in the Wicked series is Son of a Witch");
            }

            //Question three
            Console.WriteLine(" ");
            Console.WriteLine("Question three: In The Wizard of Oz, what kind of Animal is looking for courage?");
            Console.WriteLine("a) Tiger");
            Console.WriteLine("b) Lion");
            Console.WriteLine("c) Goat");
            Console.WriteLine("d) Dog");
            answerThree = Console.ReadLine();

            if (answerThree.ToLower() == "b")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Correct! It was the Cowardly Lion who was travelling the yellow brick road");
                score += 1;
            }

            else if (answerThree.ToLower() == "a")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. Where have you ever heard of a cowardly tiger");
                Console.WriteLine("The answer was b");
            }

            else if (answerThree.ToLower() == "c")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. There is a Goat in the Wicked series with a very important role in the story,");
                Console.WriteLine("but he is not in the original story of The Wizard of Oz");
                Console.WriteLine("The answer was b");
            }

            else if (answerThree.ToLower() == "d")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. You may be thinking of Courage the Cowardly Dog");
                Console.WriteLine("The answer was b");
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. That wasn't even one of the options. The answer was c");
            }

            //Question four
            Console.WriteLine(" ");
            Console.WriteLine("Question three: True or False; The Wicked Witch of the East was killed by a house.");
            answerFour = Console.ReadLine();

            if (answerFour.ToLower() == "true" || answerFour.ToLower() == "t")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Correct! The house got there by way of supernatural disaster, and fell directly on her head");
                score += 1;
            }

            else if (answerFour.ToLower() == "false" || answerFour.ToLower() == "f")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. The Wicked Witch of the East was killed by a house that fell on her head");
            }

            else { Console.WriteLine("Do you know what true or false means? That answer was so incorrect it wasn't even an option"); }

            
        }
    }
}
