namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static void PrintAllTitles(params string[] titles) //q12
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
        static void Main(string[] args)
        {
            //Question 12:
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Design Patterns");
            Console.WriteLine();

            //--------------------------------
        }
    }
}
