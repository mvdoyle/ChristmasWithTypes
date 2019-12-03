using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //TODO set Santa's name to Kris Kringle
            xmas.Santa = null;

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{ "Xbox", "Nintendo Switch", "iPhone X"}; 

            //TODO Set the TreeHeight to 10
            xmas.TreeHeight = null;

            Console.WriteLine($"This year christmas falls on {xmasDay}");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"We like to call Santa, {xmas.Santa}");
        }
    }
}
