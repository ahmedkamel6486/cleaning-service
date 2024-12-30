using System.Threading.Channels;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SmaalRoom = 25;
            int LargRoom = 35;





            Console.WriteLine("Welcome to carpet cleaning service \n this offer is valid for 30 days only Small Room.25$ . larg Room.35$ ");

            Console.WriteLine(" Price Per Smaal Room 25$ \n Number of Smaal Carpets ? ");
            int Smallcarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"total   price carpets  is {Smallcarpet * SmaalRoom:c}");
            Console.WriteLine(".............................................................");
            int TotalSmall = Smallcarpet * SmaalRoom;











            Console.WriteLine(" price per larg room 35$ \n Number of larg carpets ? ");
            int Largcarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" total   price carpets  is {Largcarpet * LargRoom:c}");
            int TotalLarg = Largcarpet * LargRoom;
            int TotalCost = TotalSmall + TotalLarg;
            Console.WriteLine("............................................................");
            Console.WriteLine($"Total cost after tax {TotalCost + 6.6:c}");

            Console.ReadLine();



            



















































        }
    }
}
