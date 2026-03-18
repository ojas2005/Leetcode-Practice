using System;
using System.Collections.Generic;

public class FindPlayersWithZeroOrOneLosses
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        Dictionary<int, int> losses = new Dictionary<int, int>();
        foreach (var match in matches)
        {
            int winner = match[0];
            int loser = match[1];
            if (!losses.ContainsKey(winner)) losses[winner] = 0;
            if (!losses.ContainsKey(loser)) losses[loser] = 0;
            losses[loser]++;
        }

        List<int> zeroLoss = new List<int>();
        List<int> oneLoss = new List<int>();

        foreach (var kvp in losses)
        {
            if (kvp.Value == 0) zeroLoss.Add(kvp.Key);
            else if (kvp.Value == 1) oneLoss.Add(kvp.Key);
        }

        zeroLoss.Sort();
        oneLoss.Sort();

        return new List<IList<int>> { zeroLoss, oneLoss };
    }
}
