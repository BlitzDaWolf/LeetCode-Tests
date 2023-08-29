package Solutions;

public class bestClosingTimeClass {
    public bestClosingTimeClass() {
        bestClosingTime("YYNY");
        bestClosingTime("NNNNN");
        bestClosingTime("YYYY");
        bestClosingTime("YNYY");
    }

    public int bestClosingTime(String customers) {
        int j=-1, s=0, ms=0;
        char[] a = customers.toCharArray();
        for (int i = 0; i < a.length; i++) {
            s += a[i] == 'Y' ? 1 : -1;
            if (s>ms){
                j=i;
                ms=s;
            }
        }
        return j+1;
    }
}
