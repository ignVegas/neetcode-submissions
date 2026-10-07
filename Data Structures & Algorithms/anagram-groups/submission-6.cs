public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagram_map = new();

        foreach(string word in strs) {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sortedKey = new string(chars);

            if(!anagram_map.ContainsKey(sortedKey)) {
                List<string> list = new List<string>();
                anagram_map[sortedKey] = list;
            }
            anagram_map[sortedKey].Add(word);
        }
        return anagram_map.Values.Select(g => g.ToList()).ToList();
    }
}
