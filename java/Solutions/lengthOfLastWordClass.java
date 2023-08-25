package Solutions;

public class lengthOfLastWordClass {
    public int lengthOfLastWord(String s) {
        String[] res = s.trim().split(" ");
        return res[res.length-1].length();
    }
}
