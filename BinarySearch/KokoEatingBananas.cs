using System;

public class KokoEatingBananas
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int lo = 1, hi = 0;
        foreach (int p in piles) hi = Math.Max(hi, p);
        
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (CanEatAll(piles, mid, h))
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    private bool CanEatAll(int[] piles, int speed, int h)
    {
        int hours = 0;
        foreach (int p in piles)
        {
            hours += (p + speed - 1) / speed;
            if (hours > h) return false;
        }
        return true;
    }
}
