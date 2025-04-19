using System.Security.Cryptography.X509Certificates;

namespace Datatypes_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * DataType and Variables 
             * integer
             * float
             * decimal
             * double
             * */

            int n = 25;
            Console.WriteLine("x is " + n);
            n = 40;
            Console.WriteLine("x is now " +n);

            float x = 1.2f;
            decimal y = 1.2M;
            double z = 1.2;

            /* 
            * what is the diffrence between console.writeline() and console.write()
            *   console.writeline() is Prints the text and moves to a new line afterward.
            *   console.write()     is Prints the text on the same line. 
            */

            Console.WriteLine("X IS " + x);
            Console.WriteLine("Y IS " + y);
            Console.WriteLine("Z IS " + z);

            Console.Write("x is " + x);
            Console.Write(":y is " + y);
            Console.Write(" :z is " + z);
            Console.WriteLine();
            
            
            /*
             * String in c# 
             *  char in c#
             */

            string FirstName = "Nada";
            string LastName = "Mohamed";
            string age = "123";
            char letter = 'N';
            Console.WriteLine("my firstName is " + FirstName +" and lastName " + LastName +" and age "+age +"my FAV letter "+ letter);

            /*
             * boolean in c#
             * 
             */

            bool IsWorking = true;
            Console.WriteLine(IsWorking);


            /*
             * type conversion ===> implicit and explicit 
             *  implicit convert from small to big
             *  explicit convert from  big to small
             * */

            int intvar = 5;
            double doublevar = 15.2;
            Console.WriteLine("implicit conversion");
            double result = intvar;
            Console.WriteLine(result); //5
            Console.WriteLine("explicit conversion");
            intvar = (int)doublevar;
            Console.WriteLine(intvar);  //15

            /*
             * How to define or get the type of a variable in C#:
             *  use class Type and work instance from it
             */

            Type t1 = intvar.GetType();
            Console.WriteLine(t1);

            Type t2 = doublevar.GetType();
            Console.WriteLine(t2);


            /*
             * what is value type and refrence type in c#?
             *  value type is stored in stack and contain the actual data , 
             *  when you assigin value type to another , copy the value 
             *  changing one variable does not effect the other.
             *   Refrence type is stored in heap and refrence in stack 
             *   when you assigin value type to another , copy the refrence
             *   changing one variable effect the other variable .
             */


            /* value type **/
            int a = 10;
            int b = a; //10
            b = 20;
            Console.WriteLine(b); // 20
            Console.WriteLine(a);// 10


            /* refrence type **/
            string name1 = "nada";
            string name2 = name1;
            Console.WriteLine(name2); // nada
            name2 = "mohamed";
            Console.WriteLine(name1);   // nada 


            /* var keyword */
            var name = "nada";
            var Charletter = 'N';
            var number = 10;

           
                
             





        }
    }
}
