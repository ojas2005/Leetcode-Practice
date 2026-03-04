public class ArrangingCoins
{
    public int ArrangeCoins(int n)
    {
        long lo = 0, hi = n;
        while (lo <= hi)
        {
            long mid = lo + (hi - lo) / 2;
            long curr = mid * (mid + 1) / 2;
            if (curr == n) return (int)mid;
            if (n < curr) hi = mid - 1;
            else lo = mid + 1;
        }
        return (int)hi;
    }
}
