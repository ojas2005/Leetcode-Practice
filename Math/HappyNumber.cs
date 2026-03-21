public class HappyNumber
{
    public bool IsHappy(int n)
    {
        int slow = n, fast = n;
        do
        {
            slow = GetNext(slow);
            fast = GetNext(GetNext(fast));
        } while (slow != fast);
        return slow == 1;
    }

    private int GetNext(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int d = n % 10;
            sum += d * d;
            n /= 10;
        }
        return sum;
    }
}
