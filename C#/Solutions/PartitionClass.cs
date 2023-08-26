class PartitionClass
{
    public ListNode Partition(ListNode head, int x)
    {
        if (head == null) return null;
        List<ListNode> nodes = new List<ListNode>();
        {
            ListNode current = head;
            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }
        }
        nodes.ForEach(x => x.next = null);
        List<ListNode> final = nodes
            .Where(y => y.val < x)
            .Concat(nodes.Where(y => y.val >= x)).ToList();
        for (int i = 0; i < final.Count - 1; i++)
        {
            final[i].next = final[i + 1];
        }
        return final[0];
    }
}