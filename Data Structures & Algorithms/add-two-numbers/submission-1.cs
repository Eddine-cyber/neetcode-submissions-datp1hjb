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
        int iteration = 0;

        while(l1 is not null || l2 is not null){

            Console.WriteLine("----- Iteration " + iteration + " -----");

            Console.WriteLine("l1 = " + (l1 != null ? l1.val.ToString() : "null"));
            Console.WriteLine("l2 = " + (l2 != null ? l2.val.ToString() : "null"));
            Console.WriteLine("carryOver (before) = " + carryOver);

            int l1Val = l1 is not null ? l1.val : 0;
            int l2Val = l2 is not null ? l2.val : 0;

            int sum = carryOver + l1Val + l2Val;

            Console.WriteLine("sum = " + sum);

            carryOver = sum>9 ? 1 : 0;

            Console.WriteLine("carryOver (after) = " + carryOver);

            result.val = sum%10;

            Console.WriteLine("result current val = " + result.val);

            PrintList(resultHead, "result so far");

            l1 = l1?.next;
            l2 = l2?.next;

            if(l1 != null || l2 != null || carryOver != 0){
                result.next = new ListNode(carryOver, null);
                result = result.next;    
            }

            iteration++;
        }
        return resultHead;
    }

    public void PrintList(ListNode head, string name)
    {
        Console.Write(name + " : ");
        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");
    }
}
