package Solutions;

import java.util.ArrayList;
import java.util.List;

public class reverseWordsClass {
    public reverseWordsClass() {
        reverseWords("the sky is blue");
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
}
