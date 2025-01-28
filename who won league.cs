//who won the league
using System;
using System.Linq;

public class EPL
{
    public static string EPLResult(string[] table, string team)
    {
        // Parse the input table into a list of team results
        var teams = table.Select(row => row.Split(','))
                         .Select(parts => new
                         {
                             Name = parts[0].Trim(),
                             Played = int.Parse(parts[1].Trim()),
                             Won = int.Parse(parts[2].Trim()),
                             Drawn = int.Parse(parts[3].Trim()),
                             Lost = int.Parse(parts[4].Trim()),
                             GoalDiff = int.Parse(parts[5].Trim()),
                             Points = (int.Parse(parts[2].Trim()) * 3) + (int.Parse(parts[3].Trim()))
                         })
                         .OrderByDescending(t => t.Points)
                         .ThenByDescending(t => t.GoalDiff)
                         .ToList();

        // Find the team position based on the name
        var teamInfo = teams.FirstOrDefault(t => t.Name.Equals(team, StringComparison.OrdinalIgnoreCase));

        if (teamInfo == null)
        {
            return "Team not found.";
        }

        // Find the position of the team in the sorted list
        int position = teams.IndexOf(teamInfo) + 1;

        // Return the formatted result
        return $"{teamInfo.Name} came {position}st with {teamInfo.Points} points and a goal difference of {teamInfo.GoalDiff}!";
    }

    public static void Main()
    {
        string[] table = {
            "Arsenal, 38, 14, 14, 10, 8",
            "Aston Villa, 38, 9, 8, 21, -26",
            "Bournemouth, 38, 9, 7, 22, -26",
            "Brighton, 38, 9, 14, 15, -15",
            "Burnley, 38, 15, 9, 14, -7",
            "Chelsea, 38, 20, 6, 12, 15",
            "Crystal Palace, 38, 11, 10, 17, -19",
            "Everton, 38, 13, 10, 15, -12",
            "Leicester City, 38, 18, 8, 12, 26",
            "Liverpool, 38, 32, 3, 3, 52",
            "Manchester City, 38, 26, 3, 9, 67",
            "Manchester Utd, 38, 18, 12, 8, 30",
            "Newcastle, 38, 11, 11, 16, -20",
            "Norwich, 38, 5, 6, 27, -49",
            "Sheffield Utd, 38, 14, 12, 12, 0",
            "Southampton, 38, 15, 7, 16, -9",
            "Tottenham, 38, 16, 11, 11, 14",
            "Watford, 38, 8, 10, 20, -28",
            "West Ham, 38, 10, 9, 19, -13",
            "Wolves, 38, 15, 14, 9, 11"
        };

        // Test cases
        Console.WriteLine(EPLResult(table, "Liverpool"));
        Console.WriteLine(EPLResult(table, "Manchester Utd"));
        Console.WriteLine(EPLResult(table, "Norwich"));
    }
}
