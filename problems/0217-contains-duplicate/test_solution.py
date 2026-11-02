import unittest
import sys
import os

sys.path.insert(0, os.path.dirname(__file__))
from solution import Solution

class TestContainsDuplicate(unittest.TestCase):
    def setUp(self):
        self.sol = Solution()

    def test_has_duplicates(self):
        self.assertTrue(self.sol.containsDuplicate([1, 2, 3, 1]))

    def test_all_distinct(self):
        self.assertFalse(self.sol.containsDuplicate([1, 2, 3, 4]))

    def test_multiple_duplicates(self):
        self.assertTrue(self.sol.containsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]))

    def test_single_element(self):
        self.assertFalse(self.sol.containsDuplicate([42]))

if __name__ == '__main__':
    unittest.main()
