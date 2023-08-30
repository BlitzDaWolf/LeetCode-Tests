package Solutions;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class splitWordsBySeparatorClass {
    public splitWordsBySeparatorClass() {
        
    }
    public List<String> splitWordsBySeparator(List<String> words, char separator) {
        String finalStr = "";
        for (String string : words) {
            finalStr += string + separator;
        }
        return Arrays.asList(finalStr.split(separator + ""));
    }
}