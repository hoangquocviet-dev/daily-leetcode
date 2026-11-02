# 0462. Minimum Moves to Equal Array Elements II

- **Độ khó:** Medium
- **Link LeetCode:** [LeetCode #462](https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/)
- **Chủ đề:** Array, Math, Sorting

---

## 📝 Đề bài
Cho một mảng số nguyên `nums` có kích thước `n`. Trong một bước, bạn có thể tăng hoặc giảm một phần tử bất kỳ của mảng đi `1`.

Hãy trả về số bước tối thiểu để biến tất cả các phần tử trong mảng thành bằng nhau.

Các test case được tạo để đảm bảo kết quả nằm trong giới hạn số nguyên 32-bit.

### Ví dụ 1:
```text
Input: nums = [1, 2, 3]
Output: 2
Giải thích: Chỉ cần 2 bước (mỗi bước tăng hoặc giảm một giá trị) để đưa mọi phần tử về 2:
[1, 2, 3] => [2, 2, 3] => [2, 2, 2]
```

### Ví dụ 2:
```text
Input: nums = [1, 10, 2, 9]
Output: 16
```

---

## 💡 Ý tưởng giải thuật (Intuition)
Bài toán quy về việc tìm một số nguyên $x$ sao cho tổng khoảng cách tuyệt đối từ mọi phần tử trong mảng tới $x$ là nhỏ nhất:
$$\min \sum_{i=0}^{n-1} |nums[i] - x|$$

* **Tại sao không phải là trung bình cộng (Mean)?**
  Trung bình cộng tối thiểu hóa tổng bình phương độ lệch $\sum (nums[i] - x)^2$ (L2 norm).
* **Tại sao là trung vị (Median)?**
  Trung vị (Median) tối thiểu hóa tổng giá trị tuyệt đối độ lệch $\sum |nums[i] - x|$ (L1 norm). Bất kỳ độ lệch nào dịch sang trái hoặc sang phải của trung vị đều làm tăng tổng khoảng cách.

Do đó, ta chỉ cần:
1. Sắp xếp mảng tăng dần.
2. Lấy phần tử trung vị tại vị trí `median = nums[n // 2]`.
3. Tính tổng `sum(|nums[i] - median|)`.

---

## ⏱️ Phân tích độ phức tạp (Complexity)
- **Thời gian (Time Complexity):** $\mathcal{O}(N \log N)$ do thao tác sắp xếp mảng. (Có thể tối ưu xuống $\mathcal{O}(N)$ bằng thuật toán Quickselect tìm median).
- **Không gian (Space Complexity):** $\mathcal{O}(1)$ (bộ nhớ phụ).

---

## 🏆 Kết quả nộp LeetCode thực tế
- **Trạng thái:** `Accepted` (33/33 test cases passed)
- **Runtime:** `5 ms` (Beats 43.62%)
- **Memory:** `20.5 MB` (Beats 24.73%)
- **Tài khoản:** [@FGFoUbjLHH](https://leetcode.com/u/FGFoUbjLHH/)
