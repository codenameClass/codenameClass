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
    public ListNode MiddleNode(ListNode head) {

        ListNode result = head;
        ListNode endNode = head;
        int length = 1;

        while(endNode is not null)
        {
            endNode = endNode.next;
            length++;

            if (length % 2 == 1)
            {
                result = result.next;
            }
        }

        return result;
    }
}