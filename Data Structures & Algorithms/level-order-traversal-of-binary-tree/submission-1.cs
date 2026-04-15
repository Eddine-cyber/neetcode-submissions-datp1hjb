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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root is null) return new();
        List<List<int>> list = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode> ();
        queue.Enqueue(root);
        while(queue.Count > 0){
            List<int> listLevel = new List<int>();
            int nNodesLevel = queue.Count;
            for(int i = 0; i < nNodesLevel; i++){
                TreeNode currentNode = queue.Dequeue();
                listLevel.Add(currentNode.val);
                if(currentNode.left is not null){
                    queue.Enqueue(currentNode.left);
                }
                if(currentNode.right is not null){
                    queue.Enqueue(currentNode.right);
                }
            }
            list.Add(listLevel);
        }
        return list;
    }
}
