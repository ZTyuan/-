using System;

public class TreasureHuntSystem
{
    public static int MaxTreasureValue(int[] treasures)
    {
        if (treasures == null || treasures.Length == 0)
            return 0;

        int n = treasures.Length;
        if (n == 1)
            return treasures[0];

        // dp[i, 0] 表示不使用魔法钥匙到达第i个宝箱的最大价值
        // dp[i, 1] 表示使用魔法钥匙到达第i个宝箱的最大价值
        int[,] dp = new int[n, 2];

        // 初始化
        dp[0, 0] = Math.Max(treasures[0],0);
        dp[0, 1] = Math.Max(treasures[0],0);
        dp[1, 0] = Math.Max(Math.Max(treasures[0], treasures[1]),0);//选一个或者都不选
        dp[1, 1] = Math.Max(treasures[0] + treasures[1], dp[1,0]);

        // 动态规划填表
        for (int i = 2; i < n; i++)
        {
            dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 2, 0] + treasures[i]);
            dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 2, 0] + treasures[i - 1] + treasures[i]);
        }

        // 返回最大值
        return Math.Max(dp[n - 1, 0], dp[n - 1, 1]);
    }
    static void Main()
    {
        // 测试使用魔法钥匙的情况
        Console.WriteLine(MaxTreasureValue(new int[] { 2, 7, 9, 3, 1 })); 
        // 测试包含负值宝箱的情况
        Console.WriteLine(MaxTreasureValue(new int[] { 3, -1, -1, -2, 4 })); 
    }
}

