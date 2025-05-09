namespace Working_with_Array_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Array is astructure represent fixed length 
             *  with the same type
             */


            //// declare array 
            //int[] numbers;
            //// alocate array
            //numbers = new int[5];

            //int[] numberS = new int[5];
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };


            var cities = new string[] { "cairo", "alex", "zagazig" };
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine("===============");

            // foreach 

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            // reversing in 1D Array

            var genders = new char[] { 'f', 'f', 'm', 'f', 'm', 'f', 'm', 'f' };
            int males = 0, femals = 0;
            foreach (var gender in genders)
            {
                if (gender == 'f')
                    femals++;
                else if (gender == 'm')
                    males++;
            }
            Console.WriteLine($"the number of femals ={femals}");
            Console.WriteLine($"the number of melaes ={males}");


            // find min and max element in array (hard code)
            int[] elements = new int[] { 665, 233, 789, 493, 123 };
            int max = 0, min = 0;
            max = elements[0];
            min = elements[0];
            for(int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                    max = elements[i];
                else if (elements[i] < min)
                    min = elements[i];
            }

            Console.WriteLine(max);
            Console.WriteLine(min);


            // // find min and max element in array (easy code)
            Console.WriteLine(elements.Max());
            Console.WriteLine(elements.Min());









            // sorting array by using bubble sort in c#
            int[] nums = new int[] { 9, 4, 7, 5, 3, 9, 1 };
            int swap;
            for(int k = 0; k < nums.Length - 1; k++)
            {
                for(int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        swap = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = swap;
                    }
                }
            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }



            ///// may bu used easy method



            int[] number = new int[] { 9, 4, 7, 5, 3, 9, 1 };

            Array.Sort(number);
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }










        }
    }
}
