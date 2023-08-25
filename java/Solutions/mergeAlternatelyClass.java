package Solutions;

public class mergeAlternatelyClass {
    public mergeAlternatelyClass() {
        mergeAlternately("abc", "pqr");
        mergeAlternately("ab", "pqrs");
        mergeAlternately("abcd", "pq");
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
}
