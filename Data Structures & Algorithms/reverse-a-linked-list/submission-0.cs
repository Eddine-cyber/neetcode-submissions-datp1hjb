/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null){return head;}
        var node = head;
        ListNode prev = null;
        var next = node.next;
        var i =0;
        while(node != null){
            Console.WriteLine("====================================");
            Console.WriteLine("i   = "+ i);
            Console.WriteLine("node = "+ node.val);
            node.next = prev;
            if(node.next != null) Console.WriteLine("node.next = "+ node.next.val);
            else Console.WriteLine("node.next is null ");
            prev = node;
            if(prev != null) Console.WriteLine("prev = "+ prev.val);
            else Console.WriteLine("prev is null ");
            node = next;
            if(node != null) Console.WriteLine("node = "+ node.val);
            else Console.WriteLine("node is null ");   
            if(next != null) next = next.next;
            if(next != null) Console.WriteLine("next = "+ next.val);
            else Console.WriteLine("next is null ");
            i++;
        }
        if(prev != null) Console.WriteLine("prev = "+ prev.val);
        else Console.WriteLine("prev is null ");
        return prev;
    }
}
