class RemoveNthFromEndClass
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if(head == null) return null;
        if (head.next == null) return null;
        int c = -1;
        { ListNode cu = head; while(cu != null) { c++; cu = cu.next; } }

        {
            ListNode cu = head;

            for (int i = 0; i < c-n; i++)
            {
                cu= cu.next;
            }

            if(c-n < 0)
            {
                head = head.next;
            }

            cu.next = cu.next.next;
        }

        return head;
    }
}