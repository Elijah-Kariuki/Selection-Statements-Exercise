namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myFavoriteNumber = 222;
            Console.WriteLine("Try to guess my favorite number!!");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess > myFavoriteNumber)
            {
                Console.WriteLine("Too High");
            }
            else if(userGuess < myFavoriteNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
            
            Console.WriteLine("What is your favorite programming language");
            string userAnswer = Console.ReadLine();
            string programmingLanguage = userAnswer.ToUpper();

            switch (programmingLanguage)
            {
                case "C#":
                    Console.WriteLine("You are in the right class");
                    break;
                case "JAVA":
                    Console.WriteLine("The universal programming languge!!");
                    break ;
                case "PYTHON":
                    Console.WriteLine("Excellent choice for a beginner");
                    break;
                    case "JAVASCRIPT":
                    Console.WriteLine("Unless you know Node.JS all that JavaScript is good for is web development");
                    break;
                    default: 
                    Console.WriteLine("Never heard of it");
                    break;  

            }    
        }
    }
}