namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  conditional statement
             *   if
             *  
             *  **/
            int x = 7, y = 5;
            if(x>y)
                Console.WriteLine("x is greater than y");
            else if( x< y)
                Console.WriteLine("x is less than y");
            else if (x == y)
                Console.WriteLine("x is equal  y ");
            else
                Console.WriteLine(" error");


            /*  Nested if **/
            Console.WriteLine("enter First Number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Second Number");
            int number2 = int.Parse(Console.ReadLine());

            if( x==y)
                Console.WriteLine(" x is equal y");
            else
            {
                if(x >y)
                    Console.WriteLine("x is greater than y");
                else if(x<y)
                    Console.WriteLine("x is less than y");
            }

            /**  logical operator in c#
             * AND operator  two condition must is true
             * Or operator    one condition is true 
             */



            /** ternary operator ***/
            int num1 = 15, num2 = 7;
            var result = x > y ? "x is greater y" : "x is less than y";
            Console.WriteLine(result);


            /*  switch in c#  **/

            var temp = "1";
            //switch(temp)
            //{
            //    case <= 20.2:
            //        Console.WriteLine("temp is low ");
            //        break;
            //    case >= 5.0:
            //        Console.WriteLine("tem is high");
            //        break;
            //    deafult:
            //        Console.WriteLine("temp is zero");
            //        break;  
            //}

            /**   switch syntax update **/

            var message = temp switch
            {
                "one" => "one",
                "2" => "two",
                "3" => "three",
                _ => "error"
            };













        }
    }
}
