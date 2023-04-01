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

        List<ListNode> values = new List<ListNode>();
        int length = 0;

        while(head is not null) {
            values.Add(head);
            head = head.next;
            length++;
        }

        return values[length / 2];
    }
}