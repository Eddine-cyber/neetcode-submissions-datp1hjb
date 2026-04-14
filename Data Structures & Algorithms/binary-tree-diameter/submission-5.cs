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
        int diametre = 0;
        int hight_ = hight(root, ref diametre);
        return diametre;
    }

    public int hight(TreeNode root, ref int diametre){
        if(root is null) return 0;
        int rightHight = hight(root.right, ref diametre);
        int leftHight = hight(root.left, ref diametre);
        int diametreLocal = rightHight + leftHight;
        diametre = Math.Max(diametre, diametreLocal);
        return 1 + Math.Max(rightHight , leftHight);
    }

}
