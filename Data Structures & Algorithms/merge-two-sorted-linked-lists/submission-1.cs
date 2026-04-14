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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null || list2 == null){
            var resa = list1 == null ? list2 : list1;
            return resa;
        }
        var head = list1.val<list2.val ? list1 : list2 ;
        var res = head;
        var ptr  = list1.val<list2.val ? list2 : list1 ;
        ListNode ptrr;
        while(head.next != null){
            if(ptr.val < head.next.val){
                ptrr = head.next;
                head.next = ptr;
                head = ptr;
                ptr = ptrr;
            }else{
                head = head.next;
            }
        }
        head.next = ptr;
        return res;
    }
}