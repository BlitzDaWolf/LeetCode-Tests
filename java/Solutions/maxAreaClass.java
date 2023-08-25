package Solutions;

public class maxAreaClass {
    public int maxArea(int[] height) {
        int left=0, right = height.length-1;
        int best = 0;
        while(right > left){
            int w = right - left;
            int h = Math.min(height[left], height[right]);
            int ar = w*h;
            best = Math.max(ar, best);
            if(height[left] < height[right]) left++;
            else if(height[left] > height[right]) right--;
            else{
                left++;
                right--;
            }
        }
        return best;   
    }

}
