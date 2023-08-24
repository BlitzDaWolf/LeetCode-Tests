import java.io.Console;
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

    public int mySqrt(int x) {
        double i =0;
        while(i*i<=x){
            if((i*i <= x && (i+1)*(i+1)>x)) return (int)i;
            i++;
        }
        return 0;
    }
    
    public ListNode deleteDuplicates(ListNode head) {
        if (head == null) return null;
        ListNode current = head;
        while (current.next != null){
            if(current.next.val == current.val)
                current.next = current.next.next;
            else
                current = current.next;
        }
        return head;
    }

    public String convertToTitle(int columnNumber) {
        if (columnNumber <= 0) return "";
        int index = columnNumber > 26?columnNumber%26:columnNumber;
        index = index==0?26:index;
        return convertToTitle((int)Math.ceil((columnNumber-26d)/26d)) + ((char)(index+64))+"";
    }

    
    public String toHex(int num) {
        return String.format("%01x", num);
    }

    public List<String> fizzBuzz(int n) {
        List<String> result = new ArrayList<String>();
        for(int i = 1;i < n+1; i++){
            String r = "";
            r += i % 3 == 0 ? "Fizz": "";
            r += i % 5 == 0 ? "Buzz": "";
            if (r.isEmpty())
                r = i+"";
            result.add(r);
        }
        return result;
    }
}