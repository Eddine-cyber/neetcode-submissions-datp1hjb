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
    private int diametre = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        int hight_ = hight(root);
        return diametre;
    }

    public int hight(TreeNode root){
        if(root is null) return 0;
        int rightHight = hight(root.right);
        int leftHight = hight(root.left);
        int diametreLocal = rightHight + leftHight;
        diametre = Math.Max(diametre, diametreLocal);
        return 1 + Math.Max(rightHight , leftHight);
    }

}
