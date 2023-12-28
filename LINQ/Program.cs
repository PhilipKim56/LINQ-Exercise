namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> vidGames = new List<string>() { "Call of Duty: Modern Warfare III ", "Marvel’s Spider-Man 2", "Hogwarts Legacy", "Madden NFL 24", "Super Mario Bros. Wonder" };
            vidGames.Add("EA Sports FC 24");
            vidGames.Add("Super Mario RPG");

            var gamesInOrder = vidGames.OrderBy(name => name.Length);

            foreach (var game in gamesInOrder)
            {
                Console.WriteLine(game);
            }
        }



    }
}
