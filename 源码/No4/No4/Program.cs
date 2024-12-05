using System;

public class TalentAssessmentSystem
{
    public static double FindMedianTalentIndex(int[] fireAbility, int[] iceAbility)
    {
        int totalLength = fireAbility.Length + iceAbility.Length;
        int[] merged = new int[totalLength];
        int i = 0, j = 0, k = 0;

        while (i < fireAbility.Length && j < iceAbility.Length)
        {
            if (fireAbility[i] < iceAbility[j])
            {
                merged[k++] = fireAbility[i++];
            }
            else
            {
                merged[k++] = iceAbility[j++];
            }
        }

        while (i < fireAbility.Length)
        {
            merged[k++] = fireAbility[i++];
        }

        while (j < iceAbility.Length)
        {
            merged[k++] = iceAbility[j++];
        }

        if (totalLength % 2 == 0)
        {
            return (merged[totalLength / 2 - 1] + merged[totalLength / 2]) / 2.0;
        }
        else
        {
            return merged[totalLength / 2];
        }
    }
    static void Main()
    { }
}

