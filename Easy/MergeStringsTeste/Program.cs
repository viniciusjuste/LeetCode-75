public class Solution
{
    public static string MergeString(string str1, string str2)
    {
        var result = new System.Text.StringBuilder();

        int i = 0;
        int j = 0;

        while (i < str1.Length && j < str2.Length)
        {
            result.Append(str1[i]);
            result.Append(str2[j]);

            i++;
            j++;
        }

        while (i < str1.Length)
        {
            result.Append(str1[i]);
            i++;
        }

        while (j < str2.Length)
        {
            result.Append(str2[j]);
            j++;
        }

        return result.ToString();
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        string str1 = "abc";
        string str2 = "123456";

        var result = Solution.MergeString(str1, str2);
        Console.WriteLine(result); // Output: a1b2c3456
    }
}