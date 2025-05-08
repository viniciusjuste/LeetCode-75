// For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.



// Example 1:

// Input: str1 = "ABCABC", str2 = "ABC"
// Output: "ABC"
// Example 2:

// Input: str1 = "ABABAB", str2 = "ABAB"
// Output: "AB"
// Example 3:

// Input: str1 = "LEET", str2 = "CODE"
// Output: ""


// Constraints:

// 1 <= str1.length, str2.length <= 1000
// str1 and str2 consist of English uppercase letters.


public class Solution
{

    public static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) return string.Empty;
        int gcd = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcd);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string str1 = "ABCABC";
        string str2 = "ABC";
        string result = solution.GcdOfStrings(str1, str2);
        Console.WriteLine(result); // Output: "ABC"

        str1 = "ABABAB";
        str2 = "ABAB";
        result = solution.GcdOfStrings(str1, str2);
        Console.WriteLine(result); // Output: "AB"

        str1 = "LEET";
        str2 = "CODE";
        result = solution.GcdOfStrings(str1, str2);
        Console.WriteLine(result); // Output: ""
    }
}