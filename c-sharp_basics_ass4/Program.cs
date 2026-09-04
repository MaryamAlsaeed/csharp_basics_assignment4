namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static void AddBonusPages(int pages) //q5
        {
            pages += 50;
        }
        static void Main(string[] args)
        {
            //Question 5:
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            //it outputs 400 bec pages are value type so it just takes a copy of the main value
            Console.WriteLine();

            //--------------------------------
        }
    }
}
