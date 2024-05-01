namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite school subject:");
            string userFavSubject = Console.ReadLine();

            switch(userFavSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("English? Guess you like to read, nerd.");
                    break;
                case "history":
                    Console.WriteLine("History? What a snooze-fest.");
                    break;
                case "math":
                    Console.WriteLine("Math? Gross, no one likes math.");
                    break;
                case "science":
                    Console.WriteLine("Science? Wow, you're definitely a nerd.");
                    break;
                case "gym":
                    Console.WriteLine("Gym? Should've known you were a gross jock.");
                    break;
                default:
                    Console.WriteLine("Try again and actually enter a school subject this time.");
                    break;
            }
        }
    }
}