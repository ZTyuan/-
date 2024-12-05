using System;

public class EnergyFieldSystem
{
    public static float MaxEnergyField(int[] heights)
    {
        if (heights == null || heights.Length < 2)
        {
            return 0.0f;
        }

        int n = heights.Length;
        float maxEnergy = 0.0f;
        int left = 0;
        int right = n - 1;     
        float originS = (heights[left] + heights[right]) * (right - left);
        maxEnergy=Math.Max(maxEnergy, originS);
        //固定左边
        for (int i = right; i > left; i--)
        {
            float currS = (heights[left] + heights[i]) * (i - left);
            if (currS >= originS)
            { 
                right = i;
                originS = currS;
            }
        }
        //找左边
        for (int i = left; i < right; i++)
        {
            float currS = (heights[right] + heights[i]) * (right - i);
            if (currS >= originS)
            {
                left = i;
                originS = currS;
            }
        }
        maxEnergy = Math.Max(maxEnergy, originS);
        //固定右边
        left = 0;
        right = n - 1;
        originS = (heights[left] + heights[right]) * (right - left);
        for (int i = left; i <right; i++)
        {
            float currS = (heights[right] + heights[i]) * (right - i);
            if (currS >= originS)
            {
                left = i;
                originS = currS;
            }
        }
        //找右边
        for (int i = right; i >left; i--)
        {
            float currS = (heights[left] + heights[i]) * (i - left);
            if (currS >= originS)
            {
                right = i;
                originS = currS;
            }
        }
        maxEnergy = Math.Max(maxEnergy, originS);

        return maxEnergy/2.0f;
    }
    static void Main()
    {
        Console.WriteLine(MaxEnergyField(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
    }
}

