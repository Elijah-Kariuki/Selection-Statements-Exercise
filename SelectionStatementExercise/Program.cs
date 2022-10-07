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
        }
    }
}