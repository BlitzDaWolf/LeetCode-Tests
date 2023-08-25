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

    public int maxArea(int[] height) {
        int left=0, right = height.length-1;
        int best = 0;
        while(right > left){
            int w = right - left;
            int h = Math.min(height[left], height[right]);
            int ar = w*h;
            best = Math.max(ar, best);
            if(height[left] < height[right]) left++;
            else if(height[left] > height[right]) right--;
            else{
                left++;
                right--;
            }
        }
        return best;   
    }

    public boolean isInterleave(String s1, String s2, String s3) {
        int m = s1.length(), n = s2.length(), l = s3.length();
        if( m+n != l ) return false;

        if (m < n) return isInterleave(s2, s1, s3);
        Boolean[] dp = new Boolean[n+1];
        dp[0] = true;

        for (int j = 1; j < n+1;j++)
            dp[j]=dp[j-1] && s2.charAt(j-1)==s3.charAt(j-1);
        
        for (int i = 1; i <= m; ++i) {
            dp[0] = dp[0] && s1.charAt(i - 1) == s3.charAt(i - 1);
            for (int j = 1; j <= n; ++j) dp[j] = (dp[j] && s1.charAt(i - 1) == s3.charAt(i + j - 1)) || (dp[j - 1] && s2.charAt(j - 1) == s3.charAt(i + j - 1));
        }

        return dp[n];
    }

    public int strStr(String haystack, String needle) {
        if (needle .length() > haystack.length()) return -1;
        if (!haystack.contains(needle)) return -1;
        int p = -1;
        for (int i = 0; i < haystack.length();i++){
            boolean done = true;
            for (int j = 0; j < needle.length();j++){
                if (haystack.charAt(i+j) != needle.charAt(j)){
                    done = false;
                    break;
                }
            }
            if ( done){
                p = i;
                break;
            }
        }
        return p;
    }

    public String mergeAlternately(String word1, String word2) {
        int max1 = word1.length(), max2 = word2.length();
        int inx1 = 0, inx2 = 0;
        String result = "";
        while (result.length() != max1 + max2){
            if (inx1 == inx2){
                if (inx1 < max1)
                    result += word1.charAt(inx1);
                inx1++;
            }else{
                if (inx2 < max2)
                    result += word2.charAt(inx2);
                inx2++;
            }
        }
        return result;
    }

    public String reverseWords(String s) {
        String[] split = s.split(" ");
        List<String> res = new ArrayList<>();

        for (int i = split.length-1; i >= 0; i--){
            if (!split[i].isEmpty()){
                res.add(split[i]);
            }
        }

        return String.join(" ", res);
    }

    public int accountBalanceAfterPurchase(int purchaseAmount) {
        return 100 - Math.round(purchaseAmount / 10f) * 10;
    }

    public int maxProfit(int[] prices) {
        boolean[] tmp = new boolean[prices.length-1];
        for (int i =0; i < tmp.length; i++){
            tmp[i] = prices[i+1] > prices[i];
        }

        int current=0;
        int frame = -1;
        for (int i =0; i < tmp.length; i++){
            if (tmp[i]){
                if (frame == -1){
                    frame = prices[i];
                }
            }
            else{
                if (frame != -1){
                    current += prices[i]-frame;
                    frame = -1;
                }
            }
        }


        current += frame !=-1 ? prices[tmp.length]-frame:0;
        return current;
    }
}