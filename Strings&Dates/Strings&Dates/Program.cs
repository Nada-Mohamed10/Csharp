using System.Text;

namespace Strings_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string format
             * class string contain method format
             */
            var message = string.Format("there are {0}", 5);
            Console.WriteLine(message);

            /*
             * string builder
             * */
            var strbuilder = new StringBuilder();
            strbuilder.AppendFormat("there are {0}", 5);
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.Length);
            strbuilder.Replace('t', 'T');
            Console.WriteLine(strbuilder);

            /* simple example **/
            var total = 100;
            Console.WriteLine("there are {0} users and total = {1}",5,total);

            /*
             * format Number 
             * 
             * */

            Console.WriteLine("Number:{0:N}", 90);
            Console.WriteLine("Number:{0:C}",90);
            Console.WriteLine("Number:{0:P}",0.75);
            Console.WriteLine("Number:{0:d7}",10000);
            Console.WriteLine("Number:{0:X}",10);

            var result = 375;
            Console.WriteLine(result.ToString("c"));



            /*
             * Date Time in c#
             * DateTime is struct 
             * 
             */
            DateTime mydate = DateTime.Now;
            Console.WriteLine(mydate);


            string FormattedDate = string.Format("Date is {0}", mydate);
            Console.WriteLine("{0:yy}",FormattedDate);

            /*
             * Date only
             * Time only
             */

            DateOnly date = new DateOnly(2025, 04, 19);
            Console.WriteLine(date.Month);

            TimeOnly eventin = new TimeOnly(8, 30);
            TimeOnly eventout = new TimeOnly(15, 0);

            TimeSpan span = eventout - eventin;
            Console.WriteLine(span.TotalHours);





            /**  take input from user and get day of your birthday*/
           
            Console.WriteLine("Enter your date of birthday");
            DateOnly birthday = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(birthday.DayOfWeek);
            Console.WriteLine($"{birthday.DayOfWeek} of month {birthday.Month} year {birthday.Year}");

        }
    }
}
