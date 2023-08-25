package Solutions;

public class plusOneClass {
    public plusOneClass() {
        plusOne(new int[]{1,2,3});
        plusOne(new int[]{4,3,2,1});        
        plusOne(new int[]{9});
    }

    public int[] plusOne(int[] digits) {
        int res = 1;
        for (int i = digits.length-1; i > -1;i--){
            int result = digits[i] + res;
            res = (result - (result % 10)) / 10;
            digits[i]=result%10;
            if (res == 0) break;
        }
        if(res != 0){
            int[] tmp = new int[digits.length + 1];
            tmp[0] = res;
            for (int i =0; i < digits.length;i++) tmp[i+1] = digits[i];
            digits = tmp;
            // Add new field
        }
        return digits;
    }
}
