package Solutions;

import java.util.ArrayList;
import java.util.List;

public class mergeTwoListsClass {
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null&&list2==null) return null;
        List<ListNode> nodes= new ArrayList<ListNode>() {};
        {
            ListNode current = list1;
            while (current != null)
            {
                nodes.add(current);
                current = current.next;
            }
        }
        {
            ListNode current = list2;
            while (current != null)
            {
                nodes.add(current);
                current = current.next;
            }
        }
        nodes.sort((ListNode a, ListNode b)-> Integer.compare(a.val, b.val));
        for (int i = 0; i < nodes.size() - 1; i++)
        {
            nodes.get(i).next = nodes.get(i+1);// .next = nodes[i + 1];
        }
        return nodes.get(0);
    }
}
