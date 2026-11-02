# 0242. Valid Anagram

- **Difficulty:** Easy
- **Link:** [LeetCode #242](https://leetcode.com/problems/valid-anagram/)
- **Topics:** Hash Table, String, Sorting

---

## Problem Description
Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

An **Anagram** is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

### Examples
- **Example 1:**
  - Input: `s = "anagram"`, `t = "nagaram"`
  - Output: `true`
- **Example 2:**
  - Input: `s = "rat"`, `t = "car"`
  - Output: `false`

---

## Approach & Complexity
- Use a 26-element array to track frequencies of each character.
- **Time Complexity:** $\mathcal{O}(N)$ where $N$ is string length.
- **Space Complexity:** $\mathcal{O}(1)$ since alphabet size is bounded (26 lowercase English letters).

---

## LeetCode Submission
- **Status:** `Accepted` (56/56 test cases)
- **Runtime:** `9 ms` (Beats 82.48%)
- **Memory:** `19.2 MB` (Beats 92.83%)
