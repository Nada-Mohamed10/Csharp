namespace Nullable_types_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Nullabe types   **/
            double? num1 = null;
        

            /*  nullable coalesing operator in c# **/
            double? number1 = null;
            double total = number1 ?? 0;
            Console.WriteLine($"total:{total}");
            Console.WriteLine(total == 0 ? "zero" : "{total}");


            /*** tryparse  in c#   ***/
           bool n= int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine(x);
            Console.WriteLine(n);



            int? y = null;
            int z = y ?? 5 ;
            Console.WriteLine(z);  // 5


        }
    }
}
 