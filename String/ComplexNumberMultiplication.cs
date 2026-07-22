public class Solution
{
    public string ComplexNumberMultiply(string num1,string num2)
    {
        int[] a=Parse(num1);
        int[] b=Parse(num2);
        int real=a[0]*b[0]-a[1]*b[1];
        int imag=a[0]*b[1]+a[1]*b[0];
        return real+"+"+imag+"i";
    }
    private int[] Parse(string s)
    {
        string[] parts=s.Substring(0,s.Length-1).Split('+');
        return new int[]{int.Parse(parts[0]),int.Parse(parts[1])};
    }
}
