namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static void PrintBookInfo(string title, int pages = 300) //q10
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Pages: {pages}");
        }
        static void Main(string[] args)
        {
            //Question 10:
            PrintBookInfo("Clean Code");
            Console.WriteLine();

            //--------------------------------
        }
    }
}
