namespace Method_Overloading_and_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guest guest = new Guest();

            string guestName = "";
            Console.WriteLine("Dear Guest , What is your Name ");
            guestName = Console.ReadLine();
            if(guestName == string.Empty)
            {
                guest.guestMessage();
            }
            else
            {
                guest.guestMessage(guestName);
            }

            guest.DisplayPlayer(1, "nada");


            //  named parameter 

            guest.namedparamter(name: "nada", id: 1, goal: 4);
        }
    }
}
