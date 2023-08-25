package Solutions;

import java.util.HashSet;

public class findDuplicateClass {
    public findDuplicateClass() {
        findDuplicate(new int[]{1,3,4,2,2});
    }
    public int findDuplicate(int[] nums) {
        HashSet<Integer> result = new HashSet<>();
        for(int i =0; i < nums.length; i++){
            if (result.contains(nums[i])){
                return nums[i];
            }
            result.add(nums[i]);
        }
        return 0;
    }
}
