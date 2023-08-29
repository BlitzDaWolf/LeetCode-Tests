package Solutions;

public class maxSubArrayClass {
    public maxSubArrayClass() {
        maxSubArray(new int[] {-2,1,-3,4,-1,2,1,-5,4});
        maxSubArray(new int[] {1});
        maxSubArray(new int[] {5,4,-1,7,8});
        maxSubArray(new int[] {-2,1});
    }
    public int maxSubArray(int[] nums) {
        int max=Integer.MIN_VALUE;
        int sum=0;
        int n=nums.length;
        for(int i=0;i<n;i++){
            sum =sum +  nums[i];
            max = Math.max(sum,max);
            
            if(sum<0) sum = 0;
        }

        return max;
    }
}
