namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response); 
        }
        // not really understanding why my rider won't let me run this code? I tried redoing the fork/clone 
        // Also looked over my code with Seth's code and it looks identical to me 
        // Probably just a simple error somewhere just don't know :(
    }
}
