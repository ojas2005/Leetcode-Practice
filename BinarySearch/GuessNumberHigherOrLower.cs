public class GuessGame
{
    protected int guess(int num) { return 0; }
}

public class GuessNumberHigherOrLower : GuessGame
{
    public int GuessNumber(int n)
    {
        int lo = 1, hi = n;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            int res = guess(mid);
            if (res == 0) return mid;
            if (res < 0) hi = mid - 1;
            else lo = mid + 1;
        }
        return -1;
    }
}
