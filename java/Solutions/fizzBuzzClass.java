package Solutions;

import java.util.ArrayList;
import java.util.List;

public class fizzBuzzClass {
    public fizzBuzzClass() {
        fizzBuzz(3);
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
