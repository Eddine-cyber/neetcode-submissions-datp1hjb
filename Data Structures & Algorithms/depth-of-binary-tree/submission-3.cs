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
    public int MaxDepth(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode> ();

        int res = 0;
        if(root is not null) queue.Enqueue(root);
        while(queue.Count > 0){
            int size = queue.Count;
            for(int i =0; i<size; i++){
                TreeNode current = queue.Dequeue();
                if(current.right is not null) queue.Enqueue(current.right);
                if(current.left is not null) queue.Enqueue(current.left);  
            }

            res++;
        }
        return res;
    }
}
