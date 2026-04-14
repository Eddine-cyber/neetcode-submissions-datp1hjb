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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0, null);
        ListNode resultHead = result;
        int carryOver = 0;
        while(l1 is not null || l2 is not null){
            int l1Val = l1 is not null ? l1.val : 0;
            int l2Val = l2 is not null ? l2.val : 0;
            int sum = carryOver + l1Val + l2Val;
            carryOver = sum>9 ? 1 : 0;
            result.val = sum%10;
            l1 = l1?.next;
            l2 = l2?.next;
            if(l1 != null || l2 != null || carryOver != 0){
                result.next = new ListNode(carryOver, null);
                result = result.next;    
            }
        }
        return resultHead;
    }
}
