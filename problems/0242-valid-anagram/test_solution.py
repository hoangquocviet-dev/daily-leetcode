import unittest
import sys
import os

sys.path.insert(0, os.path.dirname(__file__))
from solution import Solution

class TestValidAnagram(unittest.TestCase):
    def setUp(self):
        self.sol = Solution()

    def test_anagram_positive(self):
        self.assertTrue(self.sol.isAnagram("anagram", "nagaram"))

    def test_anagram_negative(self):
        self.assertFalse(self.sol.isAnagram("rat", "car"))

    def test_different_lengths(self):
        self.assertFalse(self.sol.isAnagram("a", "ab"))

    def test_empty_strings(self):
        self.assertTrue(self.sol.isAnagram("", ""))

if __name__ == '__main__':
    unittest.main()
