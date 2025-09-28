namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I like math.");
                    break;
                case "science":
                    Console.WriteLine("I like science.");
                    break;
                case "history":
                    Console.WriteLine("History is also my favorite.");
                    break;
                case "english":
                    Console.WriteLine("I don't prefer english.");
                    break;
                case "pe":
                case "p.e.":
                case "physical education":
                    Console.WriteLine("I like P.E.");
                    break;
                default:
                    Console.WriteLine("I like that one too.");
                    break;
            }

        }
    }
}