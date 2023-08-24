import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Solution {
    public String longestCommonPrefix(String[] strs) {
        Arrays.sort(strs, 0, strs.length, (String a, String b) ->Integer.compare(a.length(), b.length()));
        String best = "";

        for (int i = 1; i <= strs[0].length(); i++)
        {
            String sub = strs[0].substring(0, i);
            Boolean contains = true;
            for (int j = 0; j < strs.length; j++){
                if(!strs[j].startsWith(sub)){
                    contains = false;
                    break;
                }
            }
            
            if(contains == false) break;
            best = sub;
        }

        return best;
    }

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

    public int lengthOfLastWord(String s) {
        String[] res = s.trim().split(" ");
        return res[res.length-1].length();
    }

    public int[] plusOne(int[] digits) {
        int res = 1;
        for (int i = digits.length-1; i > -1;i--){
            int result = digits[i] + res;
            res = (result - (result % 10)) / 10;
            digits[i]=result%10;
            if (res == 0) break;
        }
        if(res != 0){
            int[] tmp = new int[digits.length + 1];
            tmp[0] = res;
            for (int i =0; i < digits.length;i++) tmp[i+1] = digits[i];
            digits = tmp;
            // Add new field
        }
        return digits;
    }
}