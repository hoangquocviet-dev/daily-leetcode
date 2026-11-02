# 0462. Minimum Moves to Equal Array Elements II

- **Difficulty:** Medium
- **Link:** [LeetCode #462](https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/)
- **Topics:** Array, Math, Sorting

---

## Problem Description
Given an integer array `nums` of size `n`, return the minimum number of moves required to make all array elements equal.

In one move, you can increment or decrement an element of the array by `1`. Test cases are designed to fit within a 32-bit integer.

### Examples
- **Example 1:**
  - Input: `nums = [1, 2, 3]`
  - Output: `2`
  - Explanation: `[1, 2, 3] => [2, 2, 3] => [2, 2, 2]`
- **Example 2:**
  - Input: `nums = [1, 10, 2, 9]`
  - Output: `16`

---

## Approach & Intuition
The problem asks to find an integer $x$ that minimizes the sum of absolute differences:
$$\min \sum_{i=0}^{n-1} |nums[i] - x|$$

- The **mean** minimizes squared errors ($\sum (nums[i] - x)^2$), but the **median** minimizes absolute errors ($\sum |nums[i] - x|$).
- After sorting `nums`, the median is located at index `n // 2`.
- Total moves can be calculated directly by summing `|nums[i] - median|`.

---

## Complexity
- **Time Complexity:** $\mathcal{O}(N \log N)$ due to sorting.
- **Space Complexity:** $\mathcal{O}(1)$ auxiliary memory.
