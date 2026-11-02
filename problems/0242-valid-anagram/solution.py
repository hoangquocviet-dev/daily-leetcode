class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        """
        Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        Approach: Frequency counting using fixed array of size 26.
        Time Complexity: O(N)
        Space Complexity: O(1)
        """
        if len(s) != len(t):
            return False
        count = [0] * 26
        for i in range(len(s)):
            count[ord(s[i]) - 97] += 1
            count[ord(t[i]) - 97] -= 1
        return all(x == 0 for x in count)
