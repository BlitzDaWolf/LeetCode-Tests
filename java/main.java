public class main {
    public static void main(String[] args) {
        Solution sln = new Solution();
        int[] a = sln.plusOne(new int[]{1,2,3});
        int[] b = sln.plusOne(new int[]{4,3,2,1});        
        int[] c = sln.plusOne(new int[]{9});

        sln.convertToTitle(1);
        sln.convertToTitle(28);        
        sln.convertToTitle(701);

        System.out.println("Completed all the tests");
    }
}