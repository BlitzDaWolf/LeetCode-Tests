package Solutions;

public class maxProfitClass {
    public maxProfitClass() {
        maxProfit(new int[]{7,1,5,3,6,4});
        maxProfit(new int[]{1,2,3,4,5});
        maxProfit(new int[]{2,1,2,0,1});
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
