package Solutions;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class numComponentsClass {
    public numComponentsClass() {
        numComponents(ListNode.CreateNode(new int[]{0,1,2,3}), new int[]{0,1,3});
        numComponents(ListNode.CreateNode(new int[]{0,1,2,3,4}), new int[]{0,3,1,4});
    }

    public int numComponents(ListNode head, int[] nums) {
        List<Integer> list = Arrays.stream(nums).boxed().toList();
        List<Integer> found = new ArrayList<>();
        ListNode current = head;
        int total = 0;
        while (current != null)
        {
            if (list.contains(current.val)){
                found.add(current.val);
            }else{
                total += found.size() != 0? 1 : 0;
                found = new ArrayList<>();
            }
            current = current.next;
        }
        total += found.size() != 0? 1 : 0;
        return total;
    }
}
