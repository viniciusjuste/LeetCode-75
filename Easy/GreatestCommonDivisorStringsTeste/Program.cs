public class Solution{
    public static int Gcd(int number1, int number2){
        while(number2 != 0){
            int temp = number2;
            number2 = number1 % number2;
            number1 = temp;
        }

        return number1;
    }

    public static string GcdOfStrings(string str1, string str2){
        if(str1 + str2 != str2 + str1) return string.Empty;

        int gcd = Gcd(str1.Length, str2.Length);

        return str1.Substring(0, gcd);
    }
}

public class Program{
    public static void Main(string[] args){
        string str1 = "ABCABC";
        string str2 = "ABC";

        Console.WriteLine(Solution.GcdOfStrings(str1, str2)); // Output: "ABC"
    }
}