namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static bool TryGetPrice(string title, out double price) //q9
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            price = 0.0;
            return false;
        }
        static void Main(string[] args)
        {
            //Question 9:
            bool found = TryGetPrice("Clean Code", out double price);
            Console.WriteLine(found ? price : 0.0);
            Console.WriteLine();

            //--------------------------------
        }
    }
}
