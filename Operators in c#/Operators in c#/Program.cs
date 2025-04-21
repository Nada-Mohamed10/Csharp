namespace Operators_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Arithmetic operator */
            int number1 = 11;
            int number2 = 2;
            Console.WriteLine($"addition of two nuumber {number1+number2}");
            Console.WriteLine($"Subtraction of two number {number1 - number2}");
            Console.WriteLine($"Division of two number {number1/ number2}");
            Console.WriteLine($"multi of two number {number1 * number2}");
            Console.WriteLine($"moduls of two number {number1%number2}");

            /*  precedence of operator in c# 
             *  1- ()
             *  2- * , / , %
             *  3- + , - 
             *  **/
            Console.WriteLine(2+2*2); // 6
            Console.WriteLine((2+2)*2); // 8

            Console.WriteLine("===========================");


            /* increment and decrement in c# **/
            /* increment 
             *  postfix , prefix
             */
            // postfix increment
            int i = 5;
            Console.WriteLine(i++); // 5
            Console.WriteLine(i);  //  6

            // prefix increment 
            int j = 2;
            Console.WriteLine(++j);   // 3
            Console.WriteLine(j);     // 3

            // postfix decrement
            int k = 5;
            Console.WriteLine(k--);    // 5
            Console.WriteLine(k);     //  4

            // prefix decrement 
            int m = 4;
            Console.WriteLine(--m);  // 3
            Console.WriteLine(m);    // 3


            /** comparsion operator in c# 
             * equal than ==
             *  greater than >
             *  greater than or equal >=
             *  less than <
             *  less than or equal <= 
             *  not equal !=
             *  * **/
            int x = 5;
            int y = 4;
            Console.WriteLine(x==y);   // false 
            Console.WriteLine(x!=y);   //  true 
            Console.WriteLine(x<y);    // false 
            Console.WriteLine(x<=y);   //  false
            Console.WriteLine(x>y);    // true
            Console.WriteLine(x>=y);   //  true



            int a = 5;
            int b = a++;
            Console.WriteLine(b);  //  5
            Console.WriteLine(a);  // 6





        }
    }
}
