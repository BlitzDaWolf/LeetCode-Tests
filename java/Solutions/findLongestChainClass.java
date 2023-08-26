package Solutions;

import java.util.Arrays;

public class findLongestChainClass {
    public findLongestChainClass() {
        findLongestChain(new int[][] {new int[] {-6,9},new int[] {1,6},new int[] {8,10},new int[] {-1,4},new int[] {-6,-2},new int[] {-9,8},new int[] {-5,3},new int[] {0,3}});
    }
    public int findLongestChain(int[][] pairs) {
        int result = 1;
        Arrays.sort(pairs, 0, pairs.length, (int[] a, int[] b) ->Integer.compare(a[1], b[1]));
        int[] last = pairs[0];
        for (int i = 1; i < pairs.length; i++){
            if(pairs[i][0] > last[1]){
                result++;
                last = pairs[i];
            }
        }
        return result;
    }
}
