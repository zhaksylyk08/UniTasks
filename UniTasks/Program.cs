using Task6;

namespace UniTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new List<Month> { 
                new Month { Number = 3, Season = Season.Spring},
                new Month { Number = 4, Season = Season.Spring},
                new Month { Number = 5, Season = Season.Spring},
                new Month { Number = 6, Season = Season.Summer},
                new Month { Number = 7, Season = Season.Summer},
                new Month { Number = 8, Season = Season.Summer},
                new Month { Number = 9, Season = Season.Autumn},
                new Month { Number = 10, Season = Season.Autumn},
                new Month { Number = 11, Season = Season.Autumn},
                new Month { Number = 12, Season = Season.Winter},
                new Month { Number = 1, Season = Season.Winter},
                new Month { Number = 2, Season = Season.Winter},
            };

            Console.WriteLine("Please enter a month number (from 1 to 12):");

            int monthNumber;
            var result = Int32.TryParse(Console.ReadLine(), out monthNumber);

            if (result && monthNumber >= 1 && monthNumber <= 12) {
                var season = months?.Find(month => month.Number == monthNumber)?.Season;
                Console.WriteLine($"Season is {season}");
            } else {
                Console.WriteLine("Incorrect month number.");
            }
        }
    }
}