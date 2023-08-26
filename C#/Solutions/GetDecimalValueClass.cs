class GetDecimalValueClass
{
    public int GetDecimalValue(ListNode head)
    {
        if (head == null) return 0;
        ListNode current = head;
        int move = -1;
        while (current != null) { move++; current = current.next; }
        int result = 0;
        current = head;

        while (current != null)
        {
            result += current.val << move;
            current = current.next;
            move--;
        }

        return result;
    }
}