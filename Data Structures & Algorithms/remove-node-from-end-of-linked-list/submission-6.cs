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
        
        ListNode dummy = new ListNode(0, head);
        ListNode fast = dummy;
        ListNode slow = dummy;

        // 1. avancer fast de n+1 étapes
        for (int i = 0; i <= n; i++) {
            fast = fast.next;
        }

        // 2. avancer les deux ensemble
        while (fast != null) {
            fast = fast.next;
            slow = slow.next;
        }

        // 3. suppression
        slow.next = slow.next.next;

        return dummy.next;
    }
}
