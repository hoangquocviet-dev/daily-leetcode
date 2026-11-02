import unittest
import sys
import os

sys.path.insert(0, os.path.dirname(__file__))
from solution import Solution

class TestMinMoves2(unittest.TestCase):
    def setUp(self):
        self.sol = Solution()

    def test_example_1(self):
        # [1, 2, 3] -> 2 moves
        self.assertEqual(self.sol.minMoves2([1, 2, 3]), 2)

    def test_example_2(self):
        # [1, 10, 2, 9] -> 16 moves
        self.assertEqual(self.sol.minMoves2([1, 10, 2, 9]), 16)

    def test_single_element(self):
        self.assertEqual(self.sol.minMoves2([5]), 0)

    def test_all_elements_same(self):
        self.assertEqual(self.sol.minMoves2([7, 7, 7, 7]), 0)

    def test_negative_numbers(self):
        self.assertEqual(self.sol.minMoves2([-5, -2, 3, 10]), 20)

    def test_large_gap(self):
        self.assertEqual(self.sol.minMoves2([1, 1000000]), 999999)

if __name__ == '__main__':
    unittest.main()
