# 0217. Contains Duplicate

- **Difficulty:** Easy
- **Link:** [LeetCode #217](https://leetcode.com/problems/contains-duplicate/)
- **Topics:** Array, Hash Table, Sorting

---

## Problem Description
Given an integer array `nums`, return `true` if any value appears at least twice in the array, and return `false` if every element is distinct.

### Examples
- **Example 1:**
  - Input: `nums = [1, 2, 3, 1]`
  - Output: `true`
- **Example 2:**
  - Input: `nums = [1, 2, 3, 4]`
  - Output: `false`

---

## Approach & Complexity
- Compare the length of the original list with the length of the set of unique values.
- **Time Complexity:** $\mathcal{O}(N)$
- **Space Complexity:** $\mathcal{O}(N)$

---

## LeetCode Submission
- **Status:** `Accepted` (80/80 test cases)
- **Runtime:** `14 ms` (Beats 69.13%)
- **Memory:** `32.9 MB` (Beats 22.47%)
