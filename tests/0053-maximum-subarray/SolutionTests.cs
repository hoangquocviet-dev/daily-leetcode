using Xunit;

namespace DailyLeetCode.Tests {
    public class MaximumSubarrayTests {
        [Fact]
        public void Test_Example1() {
            var solution = new Solution();
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = solution.MaxSubArray(nums);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test_SingleElement() {
            var solution = new Solution();
            int[] nums = new int[] { 1 };
            int result = solution.MaxSubArray(nums);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_AllNegative() {
            var solution = new Solution();
            int[] nums = new int[] { -5, -2, -3 };
            int result = solution.MaxSubArray(nums);
            Assert.Equal(-2, result);
        }
    }
}