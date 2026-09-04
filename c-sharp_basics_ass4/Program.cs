namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static void ApplyDiscount(double[] prices) //q6
        {
            prices[0] -= 5;
        }
        static void Main(string[] args)
        {
            //Question 6:
            double[] pricess = { 25.5, 40.0 };
            ApplyDiscount(pricess);
            Console.WriteLine(pricess[0]);
            //it outputs 20.5 bec. array is reference type so it edits in the main value
            Console.WriteLine();

            //--------------------------------
        }
    }
}
