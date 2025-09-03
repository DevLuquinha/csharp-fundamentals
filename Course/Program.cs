using Course;

internal class Program
{
    private static void Main(string[] args)
    {
        int LEN = 10;
        Room[] rooms = new Room[LEN];

        for(int i = 0; i < LEN; i++)
        {
            rooms[i] = null;
        }

        Console.Write("How many rooms will be rented? ");
        int numRooms = int.Parse(Console.ReadLine());

        for(int i = 0; i < numRooms; i++)
        {
            Console.WriteLine("\nRENT #" + (i+1));
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int id = int.Parse(Console.ReadLine());

            rooms[id-1] = new Room()
            {
                Name = name,
                Email = email,
                Id = id
            };
        }

        Console.WriteLine("\nBusy rooms: ");
        for(int i = 0; i < LEN; i++)
        {
            if (rooms[i] != null)
            {
                Console.WriteLine(rooms[i].ToString());
            }
        }
    }
}