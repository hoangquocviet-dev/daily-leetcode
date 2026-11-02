from typing import List

class Solution:
    def minMoves2(self, nums: List[int]) -> int:
        """
        Given an integer array nums of size n, return the minimum number of moves
        required to make all array elements equal.

        In one move, you can increment or decrement an element of the array by 1.

        Approach:
        - The median of the array minimizes the sum of absolute deviations:
          sum(|nums[i] - x|).
        - Sorting the array and taking the element at index n // 2 gives the optimal median.
        - Time Complexity: O(N log N)
        - Space Complexity: O(1)
        """
        nums.sort()
        median = nums[len(nums) // 2]
        return sum(abs(x - median) for x in nums)
