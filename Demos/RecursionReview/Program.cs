namespace RecursionReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Shiro"));
            Console.WriteLine(ReverseString("Lacy"));
            Console.WriteLine(ReverseString(""));
        }


        static string ReverseString(string source)
        {
            // base case
            if(source == null || source.Length <= 1)
            {
                return source;
            }

            // recursive case
            return 
                source[source.Length - 1] // last char +
                + ReverseString(source.Substring(0, source.Length-1)); // reverse of everything else --- state change
        }
    }
}
