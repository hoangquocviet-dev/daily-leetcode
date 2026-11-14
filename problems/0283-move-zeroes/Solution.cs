public class Solution {
    public void MoveZeroes(int[] nums) {
        int insertPos = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                int temp = nums[insertPos];
                nums[insertPos++] = nums[i];
                nums[i] = temp;
            }
        }
    }
}