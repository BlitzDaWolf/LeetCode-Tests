package Solutions;

import java.util.ArrayList;
import java.util.List;

public class reverseListClass {
    public reverseListClass() {
        reverseList(ListNode.CreateNode(new int[]{1,2,3,4,5}));
    }
    public ListNode reverseList(ListNode head) {
        if (head == null) return null;
        List<ListNode> nodes = new ArrayList<>();

        while (head!=null){
            nodes.add(0, head);
            head = head.next;
            nodes.get(0).next = null;
        }
        for (int i = 0; i < nodes.size()-1; i++) {
            nodes.get(i).next = nodes.get(i + 1);
        }

        return nodes.get(0);
    }
}
