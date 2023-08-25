public class main {
    public static void main(String[] args) {
        Solution sln = new Solution();
        int[] a = sln.plusOne(new int[]{1,2,3});
        int[] b = sln.plusOne(new int[]{4,3,2,1});        
        int[] c = sln.plusOne(new int[]{9});

        sln.fizzBuzz(3);

        sln.convertToTitle(1);
        sln.convertToTitle(28);        
        sln.convertToTitle(701);

        sln.isInterleave("aa", "ab", "aaba");
        sln.isInterleave("aabcc", "dbbca", "aadbbbaccc");

        sln.strStr("sadbutsad", "sad");
        sln.strStr("leetcode", "leeto");
        sln.strStr("aaa", "aaaa");
        sln.strStr("a", "a");

        sln.mergeAlternately("abc", "pqr");
        sln.mergeAlternately("ab", "pqrs");
        sln.mergeAlternately("abcd", "pq");

        sln.reverseWords("the sky is blue");

        sln.maxProfit(new int[]{7,1,5,3,6,4});
        sln.maxProfit(new int[]{1,2,3,4,5});
        sln.maxProfit(new int[]{2,1,2,0,1});

        sln.findDuplicate(new int[]{1,3,4,2,2});

        System.out.println("Completed all the tests");
    }
}