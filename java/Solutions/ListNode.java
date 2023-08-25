package Solutions;

public class ListNode {
    int val;
    ListNode next;
    ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }

    public static ListNode CreateNode(int[] nodes){
        if (nodes.length == 0) return null;
        ListNode head = new ListNode(nodes[0]);
        ListNode current = head;

        for(int i = 1; i < nodes.length; i++){
            current.next = new ListNode(nodes[i]);
            current = current.next;
        }

        return head;
    }
}