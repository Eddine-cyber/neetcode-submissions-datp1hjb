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
        while(node != null){
            node.next = prev;
            prev = node;
            node = next; 
            if(next != null) next = next.next;
        }
        return prev;
    }
}
