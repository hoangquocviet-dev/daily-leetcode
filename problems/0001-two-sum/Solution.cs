using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int idx)) {
                return new int[] { idx, i };
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }
}