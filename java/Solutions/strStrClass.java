package Solutions;

public class strStrClass {
    public strStrClass() {
        strStr("sadbutsad", "sad");
        strStr("leetcode", "leeto");
        strStr("aaa", "aaaa");
        strStr("a", "a");
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
}
