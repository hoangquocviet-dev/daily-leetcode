from typing import List

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        """
        Check if any value appears at least twice in the array.
        Approach: Hash set comparison.
        Time Complexity: O(N)
        Space Complexity: O(N)
        """
        return len(nums) != len(set(nums))
