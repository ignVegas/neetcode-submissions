public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        if(nums == null || n == 0) return [];
        Dictionary<int, int> seen = new();
        for(int i = 0; i < n; i++) {
            int complement = target - nums[i];
            if(seen.ContainsKey(complement)) {
                return [seen[complement], i];
            } else {
                seen[nums[i]] = i;
            }
        }
        return [];
    }
}
