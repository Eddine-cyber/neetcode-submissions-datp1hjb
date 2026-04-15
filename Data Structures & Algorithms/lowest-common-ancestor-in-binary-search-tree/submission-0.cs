/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root is null) return null;
        if(Contains(root.left, p) && Contains(root.left, q)) return LowestCommonAncestor(root.left, p, q);
        if(Contains(root.right, p) && Contains(root.right, q)) return LowestCommonAncestor(root.right, p, q);
        return root;
    }
    
    bool Contains(TreeNode root, TreeNode target)
    {
        if (root == null) return false;

        if (root == target) return true;

        return Contains(root.left, target) 
            || Contains(root.right, target);
    }
}
