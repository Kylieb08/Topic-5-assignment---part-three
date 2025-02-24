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
                Console.WriteLine("Correct! The other titles in order are Wicked: The Life and Times of the Wicked Witch of the West,");
                Console.WriteLine("A Lion Among Men, and Out of Oz");
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
                Console.WriteLine("Incorrect. The only Goat of significance in any Ozian stories was Dr. Dillamond");
                Console.WriteLine("He was well known for his studification");
                Console.WriteLine("The answer was b");
            }

            else if (answerThree.ToLower() == "d")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. You may have been thinking of Toto, who was not well known for braverism");
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
                Console.WriteLine("When it happened, many citizens of Oz rejoicified.");
                score += 1;
            }

            else if (answerFour.ToLower() == "false" || answerFour.ToLower() == "f")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Incorrect. The Wicked Witch of the East was killed by a house that fell on her head");
                Console.WriteLine("Some might say it was an outward manifestorium of her twisted nature");
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Do you know what true or false means? That answer was so incorrect it wasn't even an option");
            }

            if (score > 0 && score < 100)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Your final score was " + score + ", or " + (score / 4 * 100) + "%");
                //Write a line here in what I like to call Ozified language
            }

            else if (score == 0)
            {
                Console.WriteLine("Your final score was 0.");
                Console.WriteLine("You clearly need to spend some time culturizing yourself");
                Console.WriteLine("You didn't even know that it was a lion looking for courage");
                Console.WriteLine("How are you so unfamiliar with The Wizard of Oz");
            }

            else { Console.WriteLine("Congratulotions! You are clearly well educated about the world of Oz"); }
        }
    }
}
