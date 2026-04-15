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
        list.Add(new List<int>() {root.val});
        while(queue.Count > 0){
            List<int> listLevel = new List<int>();
            int nNodesLevel = queue.Count;
            for(int i = 0; i < nNodesLevel; i++){
                TreeNode currentNode = queue.Dequeue();
                if(currentNode.left is not null){
                    queue.Enqueue(currentNode.left);
                    listLevel.Add(currentNode.left.val);
                }
                if(currentNode.right is not null){
                    queue.Enqueue(currentNode.right);
                    listLevel.Add(currentNode.right.val);
                }
            }
            if(listLevel.Count > 0) list.Add(listLevel);
        }
        return list;
    }
}
