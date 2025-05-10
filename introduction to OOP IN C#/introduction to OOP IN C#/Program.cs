namespace introduction_to_OOP_IN_C_
{
    internal class Program
    {

        public static void Displatymenssage()
        {
            Console.WriteLine("method not return type ");
            Console.WriteLine("process is done ");
            Console.WriteLine("hello nada mohamed ");
        }

        public static int addation(int num1 , int num2) 
        {
            return num1 + num2;
        }

        public static void callByValue(string fname , string lname)
        {
            string Fname = "nody";
            string Lname = "dody";
            Console.WriteLine($" replace inside function  {Fname} {Lname}");
        }
        public static void callByRef( ref string fname,ref  string lname)
        {
            string Fname = "nody";
            string Lname = "dody";
            Console.WriteLine($" replace inside function  {Fname} {Lname}");
        }

        public static int calculate(ref int total)
        {
            total += 25;
            Console.WriteLine(total);
            return total;
        }


        static void Main(string[] args)
        {
            /* OOP in C#   */
            /*  what is the oop ***/
            /*  class , object , method , property ***/
            /* what is the four of pillars of oop
             * - 1 inheritacne 
             * - 2 encapsulation
             * - 3 polymorphism 
             * - 4 abstraction 
             * ***/

            /*  method not return type ***/
            //*  call method and method is static because
            //  i not want instance from class 
            //***/

            Displatymenssage();


            /***   method with parameter and reurn value ****/
            Console.WriteLine("method with parameter ");
            Console.WriteLine(addation(2, 2));




            /*** pass by value and pass by refrence  **/
            string firstName = "nada";
            string lastName = "mohmamed";
            Console.WriteLine($" inside the main the firstName {firstName} and lastName {lastName}");
            callByValue(firstName, lastName);
            Console.WriteLine($" inside the main the firstName {firstName} and lastName {lastName}");


            Console.WriteLine("call by refrence ");
            callByRef(ref firstName, ref lastName);
            Console.WriteLine($" inside the main the firstName {firstName} and lastName {lastName}");



            int total = 0;
            total = 75;
            Console.WriteLine(total);//75
            calculate(ref total);   //100
            Console.WriteLine(total);  // 100
        }
    }
}
