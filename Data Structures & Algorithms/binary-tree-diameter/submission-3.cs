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
        Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
        int rootDiametre = diametreNode(root);
        stack.Push(new Tuple<TreeNode, int> (root, rootDiametre));
        int diametre = rootDiametre;
        while(stack.Count > 0){
            Tuple<TreeNode, int> current = stack.Pop();
            TreeNode currentNode = current.Item1;
            if(currentNode is not null){
                int rightDiameter = diametreNode(currentNode.right);
                int leftDiameter = diametreNode(currentNode.left);
                stack.Push(new Tuple<TreeNode, int> (currentNode.right, rightDiameter));
                stack.Push(new Tuple<TreeNode, int> (currentNode.left, leftDiameter));
                diametre = Math.Max(diametre, Math.Max(rightDiameter, leftDiameter));
            }
        } 
        return diametre;
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
