/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
        

        if (players.ContainsKey(playerId))
        {
            players[playerId] += points;
        }
        else
        {
            players[playerId] = points;
        }
        }

        var topPlayers = new string[10];
        foreach (var kvp in players)
        {
            var playerId = kvp.Key;
            var totalPoints = kvp.Value;

            for (int i = 0; i < topPlayers.Length; i++)
            {
                if (topPlayers[i] == null)
                {
                    topPlayers[i] = playerId;
                    break;
                }
                var currentTopPlayerId = topPlayers[i];
                var currentTopPoints = players[currentTopPlayerId];
                if (totalPoints > currentTopPoints)
                {
                    // Shift down the lower players
                    for (int j = topPlayers.Length - 1; j > i; j--)
                    {
                        topPlayers[j] = topPlayers[j - 1];
                    }
                    topPlayers[i] = playerId;
                    break;
                }
            }
        }

        Console.WriteLine("\nTop 10 Career Points:");
        Console.WriteLine("---------------------");
        Console.WriteLine("Rank | Player ID | Points");
        Console.WriteLine("-------------------------");
        for (int i = 0; i < topPlayers.Length; i++)
        {
            var playerId = topPlayers[i];
            var totalPoints = players[playerId];
            Console.WriteLine($"{i + 1,4} | {playerId,9} | {totalPoints,6}");
        }
    }
}