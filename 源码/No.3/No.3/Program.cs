using System;
public class TreasureHuntSystem
{
    public static int MaxTreasureValue(int[] treasures)
{
    if (treasures == null || treasures.Length == 0)
        return 0;
    if (treasures.Length == 1)
        return treasures[0];
    if (treasures.Length == 2)
        return Math.Max(treasures[0], treasures[1]);

    //int[] dp = new int[treasures.Length];
    int pre= treasures[0];
    int aft = Math.Max(treasures[0], treasures[1]);

    for (int i = 2; i < treasures.Length; i++)
    {
        int t = Math.Max(aft, pre + treasures[i]);
        pre = aft;
        aft = t;
    }

    return aft;
}
    static void Main()
    {
        Console.WriteLine(MaxTreasureValue(new int[] { 4, 3, 2, 3 }));
    }
}
