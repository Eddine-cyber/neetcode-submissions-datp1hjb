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
    public void ReorderList(ListNode head) {
        var real_head = head;
        var slow = head;
        var fast = head;
        while(fast.next is not null && fast.next.next is not null){
            slow = slow.next;
            fast = fast.next.next;
        }
        var current1 = slow;
        slow = slow.next;
        current1.next = null;
        
        ListNode new_mid_head = ReverseList(slow);

        ListNode current;
        var new_head = real_head;
        while(new_head is not null){
            current  = new_head.next;
            new_head.next =  new_mid_head;
            new_head = new_head.next;
            new_mid_head = current;
        }
    }

    public ListNode ReverseList(ListNode head) {
        if(head is null){return head;}
        var node = head;
        ListNode prev = null;
        var next = node.next;
        while(node is not null){
            node.next = prev;
            prev = node;
            node = next; 
            if(next is not null) next = next.next;
        }
        return prev;
    }
}
