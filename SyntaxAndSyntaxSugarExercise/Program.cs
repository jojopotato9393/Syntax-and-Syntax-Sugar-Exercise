using System.Reflection.Metadata;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 9;
            var responce = "";
            //  if (answer < 9)
            // {
            //     responce = $"{answer} is less then";
            //  }
            //  else
            //  {
            //      responce = $"{answer}is greater then ";
            //  }
            responce = (answer < 5) ? $"{answer} is less then"
                    : $"{answer} is greater then or equal to five";
            Console.WriteLine(responce);








        }      
    }
}
