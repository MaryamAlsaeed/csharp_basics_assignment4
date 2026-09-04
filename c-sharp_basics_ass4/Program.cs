namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static void ReplaceArray(ref double[] prices) //q8
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static void Main(string[] args)
        {
            //Question 8:
            double[] prices11 = { 25.5, 40.0 };
            ReplaceArray(ref prices11);
            Console.WriteLine(prices11.Length);
            Console.WriteLine();
            //--------------------------------
        }
    }
}
