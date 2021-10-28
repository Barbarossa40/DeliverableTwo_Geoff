using System;

namespace DeliverableTwo_Geoff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");

            Console.WriteLine();

            Console.WriteLine("What's on your mind? ");

            const string R1 = "Hi good to see you";
            const string R2 = "I am good";
            const string R3 = "General Kenobi";
            const string R4 = "Good bye!";
            const string R5 = "I'm sorry but you already said that";
            const string R6 = "I don't understand";

            while (true)
            {
                string comment1 = Console.ReadLine();
                comment1 = comment1.ToLower();


                switch (comment1)
                {
                    case "hello":
                        Console.WriteLine(R1);
                        break;

                    case "sup":
                        Console.WriteLine(R2);
                        break;

                    case "hello there":
                        Console.WriteLine(R3);
                        break;

                    case "bye":
                        Console.WriteLine(R4);
                        return;

                    default:
                        Console.WriteLine(R6);
                        break;
                }
                string comment2 = Console.ReadLine();
                comment2 = comment2.ToLower();

                if (comment1 == comment2)
                {
                    Console.WriteLine(R5);

                }
                else
                {
                    switch (comment2)
                    {
                        case "hello":
                            Console.WriteLine(R1);
                            break;

                        case "sup":
                            Console.WriteLine(R2);
                            break;

                        case "hello there":
                            Console.WriteLine(R3);
                            break;

                        case "bye":
                            Console.WriteLine(R4);
                            return;

                        default:
                            Console.WriteLine(R6);
                            break;

                    }

                    Console.WriteLine("This is a test. This only a test. Bob's your uncle!");
                }

            }
        }
    }
}
