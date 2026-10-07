public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen = new();
        int start = 0, best = 0;
        for(int end = 0; end < s.Length; end++){
            while(seen.Contains(s[end])) {
                seen.Remove(s[start]);
                start++;
            }
            seen.Add(s[end]);
            if(end - start + 1>best) {
                best = end - start + 1;
            }
        }
        return best;
    }
}
