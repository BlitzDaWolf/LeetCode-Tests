package Solutions;

import java.util.ArrayList;
import java.util.List;

public class isPalindromeClass {
    public isPalindromeClass() {
        isPalindrome(ListNode.CreateNode(new int[]{1,2,2,1}));
        isPalindrome(ListNode.CreateNode(new int[]{1,2}));
    }
    public boolean isPalindrome(ListNode head) {
        List<Integer> nodes = new ArrayList<>();
        while (head != null){
            nodes.add(head.val);
            head = head.next;
        }
        int size = nodes.size();
        for ( int i = 0; i < size / 2; i++){
            int right = size - i -1;
            if (nodes.get(i) != nodes.get(right)){
                return false;
            }
        }
        return true;
    }
}
