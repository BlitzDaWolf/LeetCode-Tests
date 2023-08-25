package Solutions;
import java.util.Arrays;

public class longestCommonPrefixClass {
    public longestCommonPrefixClass() {
        super();
    }

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
}
