namespace Multidimensional_Array_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // MultiDimensional Array

            //int[,] twoDimArray = new int[2, 3];

            int[,] twoDimArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(twoDimArray[0,0]);


            // twoDimArray 
            Console.WriteLine("two Dimensional Array");
            for (int i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i}][{j}]={twoDimArray[i, j]}");
                }
            }



            // 3D Array

            int[,,] threeDimArray =
            {
                { {1,2,3 } ,{4,5,6 } },
                {{7,8,9 },{10,11,12 } }
            };

            for (int i = 0; i < threeDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDimArray.GetLength(k); k++)
                    {
                        Console.WriteLine($"[{i}][{j}][]{k}={threeDimArray[i,j,k]}");
                    }
                }
            }




            // jagged Array 

            int[][] jaggedArray =
            {
                new int[]{1,2,3},
                new int[]{4,5,6,7},
                new int[]{8,9,10,11,12}
            };


            for (int i = 0; i <jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

            // 2D jegged Array
            int[][,] jagged2DimArray = new int[2][,]
            {
                new int [,]{{1,2},{3,4}},
                new int [,]{{5,6},{7,8}},
            };



            //ranges and indices in c#
            var cities = new string[]
            {
             "Cairo","alex","zagazig","Citynasr"
            };
            Console.WriteLine(cities[cities.Length-1]); // Citynasr
            Console.WriteLine(^1);  //Citynasr

            var partcity = cities[0..2];
            foreach (var item in partcity)
            {
                Console.WriteLine(item);
            }
            var copyallArray = cities[..];
            foreach (var item in copyallArray)
            {
                Console.WriteLine(item);
            }




            //range 

            Range rangrcity = 0..3;
            Console.WriteLine(rangrcity.GetType());
            Console.WriteLine(rangrcity.Start);
            Console.WriteLine(rangrcity.End);
        }
    }
}
