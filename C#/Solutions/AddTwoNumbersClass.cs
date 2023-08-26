class AddTwoNumbersClass
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        List<int> v1 = new List<int>();
        { while (l1 != null) { v1.Add(l1.val); l1 = l1.next; } }
        List<int> v2 = new List<int>();
        { while (l2 != null) { v2.Add(l2.val); l2 = l2.next; } }

        if(v2.Count > v1.Count)
        {
            var tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        for (int i = 0; i < Math.Min(v1.Count, v2.Count); i++)
        {
            v1[i] += v2[i];
        }

        for (int i = 0; i < v1.Count-1; i++)
        {
            int tmp = v1[i];
            v1[i] = tmp % 10;
            v1[i + 1] += tmp / 10;
        }
        if(v1.Last() >= 10)
        {
            int tmp = v1[v1.Count -1];
            v1[v1.Count - 1] = tmp % 10;
            v1.Add(tmp / 10);
        }

        List<ListNode> nodes = new List<ListNode>() { new ListNode(v1[0])};
        for (int i = 1; i < v1.Count; i++)
        {
            ListNode node = new ListNode(v1[i]);
            nodes.Last().next = node;
            nodes.Add(node);
        }

        return nodes[0];
    }
}