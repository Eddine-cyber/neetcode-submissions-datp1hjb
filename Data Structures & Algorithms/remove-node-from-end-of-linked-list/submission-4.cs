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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var current = head; 
        int lenght = 0;
        while(current is not null){
            current = current.next;
            lenght++;
        }
        if(lenght == n){
            head = head.next;
            return head;
        }

        current = head;
        int compteur = 0;
        ListNode previous = null;
        while(compteur < lenght-n){
            previous = current;
            current = current.next;
            compteur++;
        }
        previous.next = current.next;
        return head;
    }
}
