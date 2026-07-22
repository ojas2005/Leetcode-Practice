public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] arr=s.ToCharArray();
        HashSet<char> vowels=new HashSet<char>{'a','e','i','o','u','A','E','I','O','U'};
        int l=0,r=arr.Length-1;
        while(l<r)
        {
            while(l<r&&!vowels.Contains(arr[l]))l++;
            while(l<r&&!vowels.Contains(arr[r]))r--;
            char t=arr[l];
            arr[l]=arr[r];
            arr[r]=t;
            l++;
            r--;
        }
        return new string(arr);
    }
}
