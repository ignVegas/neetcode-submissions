public class Solution {
    public bool IsPalindrome(string s) {
        int right = s.Length - 1;
        int left = 0;
        while(left < right) {
            char l = s[left];
            char r = s[right];

            if (!Char.IsLetterOrDigit(l)) {
                left++;
            } else if (!Char.IsLetterOrDigit(r)) {
                right--;
            } else if (Char.ToLower(l) != Char.ToLower(r)) {
                return false;
            } else {
                left++;
                right--;
            }
        }
        return true;
    }
}
