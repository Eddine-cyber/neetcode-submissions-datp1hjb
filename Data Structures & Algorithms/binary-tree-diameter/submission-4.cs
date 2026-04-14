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
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root is null) return 0;
        int rightDiameter = DiameterOfBinaryTree(root.right);
        int leftDiameter = DiameterOfBinaryTree(root.left);
        return Math.Max(diametreNode(root), Math.Max(rightDiameter, leftDiameter));
    }

    public int hight(TreeNode root){
        if(root is null) return 0;
        return 1 + Math.Max(hight(root.left) , hight(root.right));
    }

    public int diametreNode(TreeNode root){
        if(root is null) return 0;
        return hight(root.right) + hight(root.left);
    }
}
