namespace Constants__String_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string manipulation  **/
            String word = "   hello nada mohamed   ";
            Console.WriteLine(word.Trim());
            Console.WriteLine(word[4]);
            Console.WriteLine(word.Trim().ToUpper());
            Console.WriteLine(word.Trim().ToLower());
            Console.WriteLine(word.Length);
            Console.WriteLine(word.Replace('h','H'));
            Console.WriteLine(word.IndexOf('a'));
            Console.WriteLine(word.LastIndexOf('d'));
            Console.WriteLine(word.Substring(5));
            Console.WriteLine(word.Remove(4));
            Console.WriteLine(word.Insert(0,"parhame"));

            /* Escap sequance in c# ***/
            Console.WriteLine(" \nada\"");
            Console.WriteLine("c:\\");
            Console.WriteLine("My Dear , \n from Nada to My love \n i love you very very much ");


            /* interpolated verbatim string ***/
            var messsage = @"parham is a beautiful ,
                          and i lovw you very very much ";
            Console.WriteLine(messsage);

            var NewFile = @"C:\\Document\file.txt";
            Console.WriteLine(NewFile);


        }
    }
}
