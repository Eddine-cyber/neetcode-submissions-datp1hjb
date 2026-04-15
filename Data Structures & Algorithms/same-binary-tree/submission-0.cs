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
    private bool isSame = true;
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p is null){
            if(q is null) return true;
            else return false;
        }else{
            if(q is null) return false;
        }
        if(p.val == q.val){
            isSame = isSame && IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
            return isSame;
        }else return false;
    }
}
