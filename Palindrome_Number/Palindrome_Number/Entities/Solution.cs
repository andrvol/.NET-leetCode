namespace Palindrome_Number.Entities;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        string str = x.ToString();
        char[] numArr = str.ToCharArray();
        bool isPalindrome = true;

        for (int i = 0; i < numArr.Length; i++)
        {
            if (!(numArr[i] == numArr[numArr.Length - i - 1])) isPalindrome = false;
        }

        if (isPalindrome) return true;
        return false;
    }
}