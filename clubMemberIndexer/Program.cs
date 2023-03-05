using System;
namespace clubMemberIndexer
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }
            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;
                    if (index >= 0 && index <= Size -1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ClubMembers Harry = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which club mememers do you want to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub)) 
                        Console.WriteLine($"Enter the value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club member");
                Harry[sub-1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue or q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }
            Console.WriteLine("What is the club type?");
            Harry.ClubType = Console.ReadLine();
            Console.WriteLine("What is the club location?");
            Harry.ClubLocation = Console.ReadLine();
            Console.WriteLine("What is the date of the meeting?");
            Harry.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is the club member information");
            Console.WriteLine($"Club Members");
            for ( int i = 0; i < Size; i++ )
            {
                if (Harry[i] != string.Empty)
                    Console.WriteLine(Harry[i]);
            }
            Console.WriteLine($"Type: {Harry.ClubType}");
            Console.WriteLine($"Location: {Harry.ClubLocation}");
            Console.WriteLine($"Date: {Harry.MeetingDate}");
        }
    }
}