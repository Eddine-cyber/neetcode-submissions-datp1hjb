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
        int lenght = 0;
        var real_head = head;
        while(head is not null){
            head = head.next;
            lenght++;
        }
        int i= 0;
        var mid_head = real_head;
        while(i < (lenght-1)/2){
            mid_head = mid_head.next;
            i+=1;
        }
        var current1 = mid_head;
        mid_head = mid_head.next;
        current1.next = null;
        
        ListNode new_mid_head = ReverseList(mid_head);

        ListNode current;
        var new_head = real_head;
        while(new_head is not null){
            current  = new_head.next;
            new_head.next =  new_mid_head;
            new_head = new_head.next;
            new_mid_head = current;
        }
        head = new_head;
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
            if(next != null) next = next.next;
        }
        return prev;
    }
}
