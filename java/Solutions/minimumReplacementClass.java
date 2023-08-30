package Solutions;

public class minimumReplacementClass {
    public long minimumReplacement(int[] nums) {
        long opperations = 0;
        long prev_bound = nums[nums.length - 1];

        for (int i = nums.length-2; i >= 0; i--) {
            long num = nums[i];
            long no_of_times = (num + prev_bound - 1) / prev_bound;
            opperations += no_of_times - 1;
            prev_bound = num / no_of_times;
        }

        return opperations;
    }
}
