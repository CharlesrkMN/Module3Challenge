//create method to prompt user for animal hunger level
using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine()!);
            
            //if-else statements to output animal sounds based off hungerLevel
            if (hungerLevel >= 8)
            {
                Console.WriteLine("Listen to the Lion: Roar!");
            }
            else
            {
                Console.WriteLine("Listen to the Monkey: Ooh ooh!");
            }

            //display a zoo themed message for the day of the week
            Console.Write("Enter a day of the week (Sun-Sat) as a number (1-7): ");
            int weekDay = int.Parse(Console.ReadLine());

            switch (weekDay)
            {
                case 1: //sunday
                    Console.WriteLine("Starfish petting on Sundays!");
                    break;
                case 2: //monday
                    Console.WriteLine("Meet a Mountain Lion on Mondays!");
                    break;
                case 3: //tuesday
                    Console.WriteLine("Come hold a Toucan on Tuesdays!");
                    break;
                case 4: //wednesday
                    Console.WriteLine("Join us for 25% off on Wild Wednesdays!");
                    break;
                case 5: //thursday
                    Console.WriteLine("Swim with the Tortoises on Thusdays!");
                    break;
                case 6: //friday
                    Console.WriteLine("Pet an Artic Fox on Fridays!");
                    break;
                case 7: //saturday
                    Console.WriteLine("See Sparky the Sea Lion on Saturdays!");
                    break;

            }
        }
    }
}