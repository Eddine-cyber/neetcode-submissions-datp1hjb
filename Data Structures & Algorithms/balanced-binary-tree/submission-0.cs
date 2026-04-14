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
    public bool IsBalanced(TreeNode root) {
        if(root is null) return true;
        bool isItBalenced = true;
        int _hight = hight(root, ref isItBalenced);
        return isItBalenced;
    }

    public int hight(TreeNode root, ref bool isItBalenced){
        if(root is null) return 0;
        int rightHight = hight(root.right, ref isItBalenced);
        int leftHight = hight(root.left, ref isItBalenced);
        bool isItBalencedLocal = Math.Abs(rightHight - leftHight) > 1 ? false : true;
        if (isItBalencedLocal == false) isItBalenced = false;
        return 1 + Math.Max(rightHight , leftHight);
    }
}
