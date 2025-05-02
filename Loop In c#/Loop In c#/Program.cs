namespace Loop_In_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****  for loop **********/

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=========================");

            for (int j = 5; j > 0; j--)
            {
                Console.WriteLine(j);
            }


            /********** infinit loop *************/

            //for(int i = 0; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(; ;  )
            //{
            //    Console.WriteLine("infinit loop ");
            //}


            /*********** while loop *********/

            int c = 1;
            while (c <= 5)
            {
                Console.WriteLine($"i = {c}");
                c++;
            }


            /*********** do while  *******/


            int a = 1;
            do
            {
                Console.WriteLine($"a ={a}");
                a++;
            } while (a <= 5);


            /************ nested loop ***************/

            for (int n = 1; n <= 5; n++)
            {
                Console.WriteLine($"first loop {n}");
                for (int m = 1; m <= 5; m++)
                {
                    Console.WriteLine($"second loop {m}");
                }
            }




            /******** multiplication in table *********/

            for (int f = 1; f <= 12; f++)
            {
                for(int e =1;e<=12;e++)
                {
                    Console.WriteLine($"{f}*{e}={f*e}");
                }
                Console.WriteLine("========================");
            }


        }
    }

}


        








