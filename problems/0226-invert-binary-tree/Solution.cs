public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;
        TreeNode tmp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(tmp);
        return root;
    }
}