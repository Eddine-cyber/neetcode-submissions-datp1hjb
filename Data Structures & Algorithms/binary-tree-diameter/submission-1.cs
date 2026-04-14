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
        return diametre - 2 ;
    }

    public int rightHight(TreeNode root){
        if(root is null) return 0;
        return 1 + Math.Max(rightHight(root.right) , leftHight(root.right));
    }
    public int leftHight(TreeNode root){
        if(root is null) return 0;
        return 1 + Math.Max(rightHight(root.left) , leftHight(root.left));
    }

    public int diametreNode(TreeNode root){
        return rightHight(root) + leftHight(root);
    }
}
