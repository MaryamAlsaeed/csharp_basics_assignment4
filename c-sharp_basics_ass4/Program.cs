namespace c_sharp_basics_ass4
{
    internal class Program
    {
        public static void AddBonusPagesByRef(ref int pages) //q7
        {
            pages += 50;
        }
        static void Main(string[] args)
        {
            //Question 7:
            int pages03 = 400;
            AddBonusPagesByRef(ref pages03);
            Console.WriteLine(pages03);
            //it adds 50 on the value bec we passed by reference so it edits the address it self
            Console.WriteLine();

            //--------------------------------
        }
    }
}
