public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        return !(nums.Length == numSet.Count);
    }
}