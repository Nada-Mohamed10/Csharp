namespace Math_Function_and_Random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*************  math function ************/

            double x = 5.227;
            Console.WriteLine("Ceiling :" + Math.Ceiling(x));
            Console.WriteLine("floor :" + Math.Floor(x));
            Console.WriteLine("Round :" + Math.Round(x));
            Console.WriteLine("truncate :" + Math.Truncate(x));
            Console.WriteLine("Abs :" + Math.Abs(x));
            Console.WriteLine("multi :" + Math.BigMul(10,5));
            Console.WriteLine("max :" + Math.Max(10,20));
            Console.WriteLine("min :" + Math.Min(10,20));
            Console.WriteLine("sqrt :" + Math.Sqrt(3));
            Console.WriteLine("power :" + Math.Pow(3,2));
            Console.WriteLine("Div Reminder :" + Math.DivRem(13,2));
            Console.WriteLine("PI :" + Math.PI);






            /*********  random numbers           *****/

            Random rand = new Random();
            int month = 0;
            int dice = 0;
            month = rand.Next(1, 13);
            Console.WriteLine(month);

            dice = rand.Next(1, 7);
            Console.WriteLine(dice);





        }
    }
}
