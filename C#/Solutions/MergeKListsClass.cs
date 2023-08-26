class MergeKListsClass
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null;
        List<ListNode> nodes = new List<ListNode>();
        {
            for (int i = 0; i < lists.Length; i++)
            {
                ListNode current = lists[i];
                while (current != null)
                {
                    nodes.Add(current);
                    current = current.next;
                }
            }
        }

        nodes= nodes.OrderBy(x => x.val).ToList();

        nodes.ForEach(x => x.next = null);
        List<ListNode> final = nodes.ToList();
        if (final.Count > 1)
        {
            for (int i = 0; i < final.Count - 1; i++)
            {
                final[i].next = final[i + 1];
            }
        }
        Console.WriteLine(string.Join(",", nodes.Select(x => x.val)));
        if (final.Count == 0) return null;
        return final[0];
    }
}