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

        while(endNode is not null && endNode.next is not null)
        {
            result = result.next;
            endNode = endNode.next.next;
        }

        return result;
    }
}