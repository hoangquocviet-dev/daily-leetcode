using System;

public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int median = nums[nums.Length / 2];
        int moves = 0;
        foreach (int x in nums) {
            moves += Math.Abs(x - median);
        }
        return moves;
    }
}
